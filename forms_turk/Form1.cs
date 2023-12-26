using forms_turk.Context;
using forms_turk.Models;
using Microsoft.EntityFrameworkCore;

namespace forms_turk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            try
            {
                foreach (var item in await GetPersonelListAsync())
                {
                    listBox1.Items.Add(item.Ad + " " + item.Soyad + " " + item.TelNo);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString
                    ());
            }


        }
        public async Task<List<Personel>> GetPersonelListAsync()
        {
            using (var context = new AppDbContext())
            {
                var list = await context.Personel.ToListAsync();
                return list;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
