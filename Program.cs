using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Windows.Forms;

ApplicationConfiguration.Initialize();

var form = new Form();
form.WindowState = FormWindowState.Maximized;

int counter = 0;

Label label = new Label();
label.AutoSize = true;
label.Location = new Point(500, 480);
label.Text = $"Counter: {counter}";

Button button = new Button();
button.Text = "?????";
button.Location = new Point(500, 500);
button.Click += (o, e) =>
{
    button.Location = new Point(
        Random.Shared.Next(form.Width - 100),
        Random.Shared.Next(form.Height - 100)
    );
    
    counter++;
    label.Text = $"Counter: {counter}";
}; 

form.Controls.Add(button);
form.Controls.Add(label);

Application.Run(form);