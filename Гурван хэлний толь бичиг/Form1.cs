using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace Гурван_хэлний_толь_бичиг
{
    public partial class Form1 : Form
    {
        private readonly string _toliConn =
            "Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "toli.db");
        private readonly string _savedConn =
            "Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "saved.db");

        private int _selectedId = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Гурван хэлний толь бичиг";

            InitDb();
            InitSavedDb();

            cmbLang.Items.AddRange(new object[] { "Бүгд", "Англи", "Монгол", "Орос" });
            cmbLang.SelectedIndex = 0;

            // Зураг дээрх шиг анх харагдах placeholder текст болон саарал өнгө оруулах
            txtSearch.Text = "Хайх үг...";
            txtSearch.ForeColor = System.Drawing.Color.Gray;

            LoadData();
            LoadSaved();
        }

        private void Execute(string connStr, string sql, params (string, object)[] ps)
        {
            using (var conn = new SqliteConnection(connStr))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                foreach (var (name, value) in ps)
                    cmd.Parameters.AddWithValue(name, value);
                cmd.ExecuteNonQuery();
            }
        }

        private void InitDb()
        {
            Execute(_toliConn, @"CREATE TABLE IF NOT EXISTS words (
                                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                                    eng TEXT NOT NULL,
                                    mon TEXT NOT NULL,
                                    rus TEXT NOT NULL)");

            long count;
            using (var conn = new SqliteConnection(_toliConn))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM words";
                count = (long)cmd.ExecuteScalar();
            }
            if (count > 0) return;

            string[,] seed =
            {
                { "zero",  "тэг",    "ноль" },
                { "one",   "нэг",    "один" },
                { "two",   "хоёр",   "два" },
                { "three", "гурав",  "три" },
                { "four",  "дөрөв",  "четыре" },
                { "five",  "тав",    "пять" },
                { "six",   "зургаа", "шесть" },
                { "seven", "долоо",  "семь" },
                { "eight", "найм",   "восемь" },
                { "nine",  "ес",     "девять" },
                { "ten",   "арав",   "десять" }
            };
            for (int i = 0; i < seed.GetLength(0); i++)
            {
                Execute(_toliConn,
                    "INSERT INTO words (eng, mon, rus) VALUES ($e, $m, $r)",
                    ("$e", seed[i, 0]), ("$m", seed[i, 1]), ("$r", seed[i, 2]));
            }
        }

        private void InitSavedDb()
        {
            Execute(_savedConn, @"CREATE TABLE IF NOT EXISTS saved_words (
                                    id INTEGER PRIMARY KEY,
                                    eng TEXT NOT NULL,
                                    mon TEXT NOT NULL,
                                    rus TEXT NOT NULL,
                                    saved_at TEXT DEFAULT CURRENT_TIMESTAMP)");
        }

        private void LoadData()
        {
            string searchText = txtSearch.Text;
            if (searchText == "Хайх үг...") searchText = "";

            string q = "%" + searchText.Trim() + "%";
            string where;
            switch (cmbLang.SelectedItem?.ToString())
            {
                case "Англи": where = "eng LIKE $q"; break;
                case "Монгол": where = "mon LIKE $q"; break;
                case "Орос": where = "rus LIKE $q"; break;
                default: where = "eng LIKE $q OR mon LIKE $q OR rus LIKE $q"; break;
            }

            var table = new DataTable();
            using (var conn = new SqliteConnection(_toliConn))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText =
                    "SELECT id, eng, mon, rus FROM words WHERE " + where + " ORDER BY id";
                cmd.Parameters.AddWithValue("$q", q);
                using (var reader = cmd.ExecuteReader())
                    table.Load(reader);
            }

            dataGridView1.DataSource = table;
            dataGridView1.Columns["id"].HeaderText = "№";
            dataGridView1.Columns["eng"].HeaderText = "Англи";
            dataGridView1.Columns["mon"].HeaderText = "Монгол";
            dataGridView1.Columns["rus"].HeaderText = "Орос";

            UpdateStatusCount(table.Rows.Count);
        }

        private void LoadSaved()
        {
            var table = new DataTable();
            using (var conn = new SqliteConnection(_savedConn))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText =
                    "SELECT eng, mon, rus FROM saved_words ORDER BY saved_at DESC";
                using (var reader = cmd.ExecuteReader())
                    table.Load(reader);
            }

            dataGridView2.DataSource = table;
            dataGridView2.Columns["eng"].HeaderText = "Англи";
            dataGridView2.Columns["mon"].HeaderText = "Монгол";
            dataGridView2.Columns["rus"].HeaderText = "Орос";
        }

        private void UpdateStatusCount(int wordCount)
        {
            int savedCount = 0;
            using (var conn = new SqliteConnection(_savedConn))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM saved_words";
                savedCount = Convert.ToInt32(cmd.ExecuteScalar());
            }
            lblCount.Text = "Нийт: " + wordCount + " үг · Санасан: " + savedCount;
        }

        private void ClearInputs()
        {
            dataGridView1.CurrentCell = null;
            txtEng.Clear();
            txtMon.Clear();
            txtRus.Clear();
            _selectedId = -1;
        }

        private bool InputsValid()
        {
            if (string.IsNullOrWhiteSpace(txtEng.Text) ||
                string.IsNullOrWhiteSpace(txtMon.Text) ||
                string.IsNullOrWhiteSpace(txtRus.Text))
            {
                MessageBox.Show("Гурван хэлний үгийг бүгдийг нь бөглөнө үү.");
                return false;
            }
            return true;
        }

        // --- Хайлтын хэсгийн Enter / Leave функцүүд ---
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Хайх үг...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Хайх үг...";
                txtSearch.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Хайх үг...") return;
            LoadData();
        }

        private void cmbLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            var row = dataGridView1.CurrentRow;
            _selectedId = Convert.ToInt32(row.Cells["id"].Value);
            txtEng.Text = row.Cells["eng"].Value?.ToString();
            txtMon.Text = row.Cells["mon"].Value?.ToString();
            txtRus.Text = row.Cells["rus"].Value?.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_selectedId < 0)
            {
                MessageBox.Show("Санах үгээ сонгоно уу.");
                return;
            }

            Execute(_savedConn,
                "INSERT OR IGNORE INTO saved_words (id, eng, mon, rus) VALUES ($id, $e, $m, $r)",
                ("$id", _selectedId), ("$e", txtEng.Text.Trim()),
                ("$m", txtMon.Text.Trim()), ("$r", txtRus.Text.Trim()));
            LoadSaved();
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!InputsValid()) return;

            Execute(_toliConn,
                "INSERT INTO words (eng, mon, rus) VALUES ($e, $m, $r)",
                ("$e", txtEng.Text.Trim()),
                ("$m", txtMon.Text.Trim()),
                ("$r", txtRus.Text.Trim()));

            ClearInputs();
            LoadData();
            LoadSaved();
            MessageBox.Show("Үг амжилттай нэмэгдлээ.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedId < 0)
            {
                MessageBox.Show("Засах үгээ хүснэгтээс сонгоно уу.");
                return;
            }
            if (!InputsValid()) return;

            Execute(_toliConn,
                "UPDATE words SET eng = $e, mon = $m, rus = $r WHERE id = $id",
                ("$e", txtEng.Text.Trim()),
                ("$m", txtMon.Text.Trim()),
                ("$r", txtRus.Text.Trim()),
                ("$id", _selectedId));

            ClearInputs();
            LoadData();
            LoadSaved();
            MessageBox.Show("Үг амжилттай засагдлаа.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedId < 0)
            {
                MessageBox.Show("Устгах үгээ хүснэгтээс сонгоно уу.");
                return;
            }

            var confirm = MessageBox.Show("Энэ үгийг устгахдаа итгэлтэй байна уу?", "Баталгаажуулалт", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Execute(_toliConn, "DELETE FROM words WHERE id = $id", ("$id", _selectedId));
                ClearInputs();
                LoadData();
                LoadSaved();
                MessageBox.Show("Үг устгагдлаа.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "Хайх үг...";
            txtSearch.ForeColor = System.Drawing.Color.Gray;
            ClearInputs();
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}