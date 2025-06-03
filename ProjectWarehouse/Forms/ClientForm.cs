using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ProjectWarehouse.Files;

namespace ProjectWarehouse.Forms
{
    public partial class ClientForm : Form
    {
        CompanyDbContext Ent = new CompanyDbContext();

        public ClientForm()
        {
            InitializeComponent();
            LoadClients();
        }

        private void LoadClients()
        {
            ListBoxClient.Items.Clear();
            ListBoxClient.Items.Add($"{"ID".PadRight(5)}{"Name".PadRight(20)}{"Phone".PadRight(15)}{"Email".PadRight(25)}");

            ClientComboBox.Items.Clear();
            var clients = Ent.Clients.ToList();

            foreach (var s in clients)
            {
                ListBoxClient.Items.Add($"{s.ID.ToString().PadRight(5)}{s.Name.PadRight(20)}{s.Phone.PadRight(15)}{s.Email.PadRight(25)}");
                ClientComboBox.Items.Add(s.ID);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(PhoneTextBox.Text))
            {
                MessageBox.Show("Please fill in at least name and phone.");
                return;
            }

            Client client = new Client
            {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Fax = FaxTextBox.Text,
                Mobile = MobileTextBox.Text,
                Email = EmailTextBox.Text,
                Website = WebsiteTextBox.Text
            };

            Ent.Clients.Add(client);
            Ent.SaveChanges();
            MessageBox.Show("Client Added");
            LoadClients();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ClientComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a client to update.");
                return;
            }

            int id = (int)ClientComboBox.SelectedItem;
            var client = Ent.Clients.FirstOrDefault(c => c.ID == id);

            if (client != null)
            {
                client.Name = NameTextBox.Text;
                client.Phone = PhoneTextBox.Text;
                client.Fax = FaxTextBox.Text;
                client.Mobile = MobileTextBox.Text;
                client.Email = EmailTextBox.Text;
                client.Website = WebsiteTextBox.Text;

                Ent.SaveChanges();
                MessageBox.Show("Client Updated");
                LoadClients();
            }
        }


        private void btnDisplay_Click(object sender, EventArgs e)
        {
            LoadClients();
            MessageBox.Show("Client Refreshed");
        }

        private void ClientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClientComboBox.SelectedItem != null)
            {
                int id = (int)ClientComboBox.SelectedItem;
                var client = Ent.Clients.FirstOrDefault(s => s.ID == id);
                if (client != null)
                {
                    NameTextBox.Text = client.Name;
                    PhoneTextBox.Text = client.Phone;
                    FaxTextBox.Text = client.Fax;
                    MobileTextBox.Text = client.Mobile;
                    EmailTextBox.Text = client.Email;
                    WebsiteTextBox.Text = client.Website;
                }
            }
        }

     
    }
}
