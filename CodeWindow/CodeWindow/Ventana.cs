using System;
using System.Windows.Forms;
using System.Drawing;

public class Ventana : Form
{
    private Button btSaludo;
    private ToolTip ttToolTip1;
    private Label sLabel;
    public Ventana()
    {
        initComponents();
    }

    public void initComponents()
    {
        ClientSize = new Size(300, 250);
        Name = "Ventana 1";
        Text = "Saludo";

        //Boton
        btSaludo = new Button();
        btSaludo.Name = "btSaludo";
        btSaludo.Text = "Haga &Clic aquí";
        btSaludo.Location = new Point(53,90);
        btSaludo.Size = new Size(200, 25);
        btSaludo.TabIndex = 0;
        btSaludo.Click += new EventHandler(btSaludo_clic);
        Controls.Add(btSaludo);

        //Descripcion
        ttToolTip1 = new ToolTip();
        ttToolTip1.SetToolTip(btSaludo, "Pulsador normalmente abierto");

        //etiqueta
        sLabel = new Label();
        sLabel.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
        sLabel.Name = "sLabel";
        sLabel.Text = "Etiqueta";
        sLabel.TabIndex = 1;
        sLabel.TextAlign = ContentAlignment.MiddleCenter;
        sLabel.Location = new Point(53, 48);
        sLabel.Size = new Size(200, 25);
        Controls.Add(sLabel);

    }

    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);
    }

    public static void Main()
    {
        Application.Run(new Ventana());
    }

    private void btSaludo_clic(object sender, EventArgs e)
    {
        sLabel.Text = "Hola Mundo";
    }
}