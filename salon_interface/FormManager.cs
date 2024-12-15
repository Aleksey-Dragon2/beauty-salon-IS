using System.Collections.Generic;
using System.Windows.Forms;

public class FormManager
{
    private Dictionary<string, Form> forms = new Dictionary<string, Form>();

    public void RegisterForm(string name, Form form)
    {
        forms[name] = form;
    }

    public void ShowForm(string name)
    {
        // Скрыть все формы
        foreach (var form in forms.Values)
        {
            form.Hide();
        }

        // Показать выбранную форму
        if (forms.ContainsKey(name))
        {
            forms[name].Show();
        }
        else
        {
            MessageBox.Show($"Форма {name} не зарегистрирована!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public void CloseAllForms()
    {
        foreach (var form in forms.Values)
        {
            form.Dispose();
        }
    }
}
