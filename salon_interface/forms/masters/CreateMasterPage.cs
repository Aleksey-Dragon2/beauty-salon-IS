using salon_interface.Models;
using ProjectName.api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using loadMasters = salon_interface.MasterPage.loadMasters;
using System.Web.UI.WebControls;
namespace salon_interface
{
    public partial class CreateMasterPage : Form
    {
        private loadMasters LoadMasters;
        private List<string> suggestions;
        public CreateMasterPage(loadMasters loadMasters)
        {
            InitializeComponent();
            loadServicesList();
            this.LoadMasters = loadMasters;
            textBoxInput.TextChanged += TextBoxInput_TextChanged;
            listBoxSuggestions.Click += ListBoxSuggestions_Click;
            GetSuggetion();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = choiseServicesList.SelectedIndex;

            if (selectedIndex != -1)
            {
                choiseServicesList.SetItemChecked(selectedIndex, !choiseServicesList.GetItemChecked(selectedIndex));
                choiseServicesList.ClearSelected();
            }
        }
        
        private async void loadServicesList()
        {
            List<Service> services = await ServiceApiHandler.GetServicesAsync();
            foreach (Service service in services)
            {
            this.choiseServicesList.Items.AddRange(new object[] {$"{service.Name}"});
            }
        }

        private void labelSpecialization_Click(object sender, EventArgs e)
        {
            loadServicesList();

        }

        private async void AcceptCreateButton_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text == "")
            {
                this.textBoxInput.PlaceholderText = "Заполните поле!";
                this.textBoxInput.PlaceholderForeColor = Color.Red;
                return;
            }
            if (this.choiseServicesList.CheckedItems.Count == 0)
            {
                MessageBox.Show("Выберите услуги для мастера");
                return;
            }
            List<string> services = new List<string>();
            foreach (var item in this.choiseServicesList.CheckedItems) {
                services.Add(item.ToString());
            };
            string name = this.masterName.Text;
            string surname = this.masterSurname.Text;
            string specialization = this.textBoxInput.Text;
            await MasterApiHandler.CreateMasterAsync(name, surname, specialization, services);
            this.LoadMasters();
            this.Close();
        }

        private void DeniedCreateButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void GetSuggetion()
        {
            this.suggestions = await MasterApiHandler.GetSpecizlizationAsync();
        }

        private void TextBoxInput_TextChanged(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;

            // Фильтрация списка подсказок
            var filteredSuggestions = suggestions
                .Where(s => s.StartsWith(input, StringComparison.InvariantCultureIgnoreCase))
                .ToList();

            if (filteredSuggestions.Any() && !string.IsNullOrWhiteSpace(input))
            {
                listBoxSuggestions.DataSource = filteredSuggestions;
                listBoxSuggestions.Visible = true;
            }
            else
            {
                listBoxSuggestions.Visible = false;
            }
        }
        private void ListBoxSuggestions_Click(object sender, EventArgs e)
        {
            // Вставить выбранную подсказку в TextBox
            if (listBoxSuggestions.SelectedItem != null)
            {
                textBoxInput.Text = listBoxSuggestions.SelectedItem.ToString();
                listBoxSuggestions.Visible = false;
            }
        }
    }
}
