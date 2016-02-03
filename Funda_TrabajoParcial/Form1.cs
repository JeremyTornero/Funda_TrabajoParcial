using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funda_TrabajoParcial
{
    public partial class Form1 : Form
    {
        public Persona atendido { get; set; }
        private Control objcontrol = new Control();

        public Form1()
        {
            InitializeComponent();
            ConfigurarListaPersonasPorSuCondicion();
        }
        bool Iniciar = false;
        int tiempo = 0;
        int dp = 0;//dp->DepósitoPreferencial
        int rp = 0;//rp->RetiroPreferencial
        int dc = 0;//dc->DepósitoCliente
        int rc = 0;//rc->RetiroCliente
        int dnc = 0;//dnc->DepósitoNoCliente
        int rnc = 0;//rnc->RetiroNoCliente
        int MontoTotal_dp = 0;
        int MontoTotal_rp = 0;
        int MontoTotal_dc = 0;
        int MontoTotal_rc = 0;
        int MontoTotal_dnc = 0;
        int MontoTotal_rnc = 0;

        public void AtencionCliente()
        {
            Random r = new Random();
            int temp = r.Next(1, 4);
            switch (temp)
            {
                case 1:
                    if (objcontrol.Cola_Preferencial.Count != 0)
                    {
                        atendido = objcontrol.Cola_Preferencial.Peek(); //Cola_Ventanilla_Preferencial.Enqueue(atendido);
                        ListViewItem fila_1 = new ListViewItem(atendido.Nombre);
                        fila_1.SubItems.Add(atendido.Tramite);
                        fila_1.SubItems.Add(string.Format("{0}", atendido.monto));
                        ListView1.Items.Add(fila_1);
                        if (atendido.Tramite == "Depósito")
                        {
                            dp++;
                            MontoTotal_dp = MontoTotal_dp + atendido.monto;
                        }
                        else
                            if (atendido.Tramite == "Retiro")
                                rp++;
                        MontoTotal_rp = MontoTotal_rp + atendido.monto;
                        objcontrol.Cola_Preferencial.Dequeue();
                    }
                    else if (objcontrol.Cola_Clientes.Count != 0)
                    {
                        atendido = objcontrol.Cola_Clientes.Peek(); //Cola_Ventanilla_Preferencial.Enqueue(atendido); //Cola_Ventanilla_Preferencial.Enqueue(atendido);//objcontrol.Preferencial.Add(objcontrol.atendido);
                        ListViewItem fila_1 = new ListViewItem(atendido.Nombre);
                        fila_1.SubItems.Add(atendido.Tramite);
                        fila_1.SubItems.Add(string.Format("{0}", atendido.monto));
                        ListView1.Items.Add(fila_1);
                        if (atendido.Tramite == "Depósito")
                        {
                            dc++;
                            MontoTotal_dc = MontoTotal_dc + atendido.monto;
                        }
                        else
                            if (atendido.Tramite == "Retiro")
                                rc++;
                        MontoTotal_rc = MontoTotal_rc + atendido.monto;
                        objcontrol.Cola_Clientes.Dequeue();
                    }
                    else if (objcontrol.Cola_No_Clientes.Count != 0)
                    {
                        atendido = objcontrol.Cola_No_Clientes.Peek(); //Cola_Ventanilla_Preferencial.Enqueue(atendido); //Cola_Ventanilla_Preferencial.Enqueue(atendido);//objcontrol.Preferencial.Add(objcontrol.atendido);
                        ListViewItem fila_1 = new ListViewItem(atendido.Nombre);
                        fila_1.SubItems.Add(atendido.Tramite);
                        fila_1.SubItems.Add(string.Format("{0}", atendido.monto));
                        ListView1.Items.Add(fila_1);
                        if (atendido.Tramite == "Depósito")
                        {
                            dnc++;
                            MontoTotal_dnc = MontoTotal_dnc + atendido.monto;
                        }
                        else
                            if (atendido.Tramite == "Retiro")
                                rnc++;
                        MontoTotal_rnc = MontoTotal_rnc + atendido.monto;
                        objcontrol.Cola_No_Clientes.Dequeue();
                    }
                    break;

                case 2:
                    if (objcontrol.Cola_Clientes.Count != 0)
                    {
                        atendido = objcontrol.Cola_Clientes.Peek(); //Cola_Ventanilla_Clientes.Enqueue(atendido);//objcontrol.Clientes.Add(objcontrol.atendido);
                        ListViewItem fila_1 = new ListViewItem(atendido.Nombre);
                        fila_1.SubItems.Add(atendido.Tramite);
                        fila_1.SubItems.Add(string.Format("{0}", atendido.monto));
                        ListView2.Items.Add(fila_1);
                        if (atendido.Tramite == "Depósito")
                        {
                            dc++;
                            MontoTotal_dc = MontoTotal_dc + atendido.monto;
                        }
                        else
                            if (atendido.Tramite == "Retiro")
                                rc++;
                        MontoTotal_rc = MontoTotal_rc + atendido.monto;
                        objcontrol.Cola_Clientes.Dequeue();
                    }
                    else if (objcontrol.Cola_Preferencial.Count != 0)
                    {
                        atendido = objcontrol.Cola_Preferencial.Peek(); //Cola_Ventanilla_Clientes.Enqueue(atendido);//objcontrol.Clientes.Add(objcontrol.atendido);
                        ListViewItem fila_1 = new ListViewItem(atendido.Nombre);
                        fila_1.SubItems.Add(atendido.Tramite);
                        fila_1.SubItems.Add(string.Format("{0}", atendido.monto));
                        ListView2.Items.Add(fila_1);
                        if (atendido.Tramite == "Depósito")
                        {
                            dp++;
                            MontoTotal_dp = MontoTotal_dp + atendido.monto;
                        }
                        else
                            if (atendido.Tramite == "Retiro")
                                rp++;
                        MontoTotal_rp = MontoTotal_rp + atendido.monto;
                        objcontrol.Cola_Preferencial.Dequeue();
                    }
                    else if (objcontrol.Cola_No_Clientes.Count != 0)
                    {
                        atendido = objcontrol.Cola_No_Clientes.Peek(); //Cola_Ventanilla_Clientes.Enqueue(atendido);//objcontrol.Clientes.Add(objcontrol.atendido);
                        ListViewItem fila_1 = new ListViewItem(atendido.Nombre);
                        fila_1.SubItems.Add(atendido.Tramite);
                        fila_1.SubItems.Add(string.Format("{0}", atendido.monto));
                        ListView2.Items.Add(fila_1);
                        if (atendido.Tramite == "Depósito")
                        {
                            dnc++;
                            MontoTotal_dnc = MontoTotal_dnc + atendido.monto;
                        }
                        else
                            if (atendido.Tramite == "Retiro")
                                rnc++;
                        MontoTotal_rnc = MontoTotal_rnc + atendido.monto;
                        objcontrol.Cola_No_Clientes.Dequeue();
                    }
                    break;

                case 3:
                    if (objcontrol.Cola_No_Clientes.Count != 0)
                    {
                        atendido = objcontrol.Cola_No_Clientes.Peek(); //Cola_Ventanilla_No_Clientes.Enqueue(atendido);//objcontrol.No_Clientes.Add(objcontrol.atendido);
                        ListViewItem fila_1 = new ListViewItem(atendido.Nombre);
                        fila_1.SubItems.Add(atendido.Tramite);
                        fila_1.SubItems.Add(string.Format("{0}", atendido.monto));
                        ListView3.Items.Add(fila_1);
                        if (atendido.Tramite == "Depósito")
                        {
                            dnc++;
                            MontoTotal_dnc = MontoTotal_dnc + atendido.monto;
                        }
                        else
                            if (atendido.Tramite == "Retiro")
                                rnc++;
                        MontoTotal_rnc = MontoTotal_rnc + atendido.monto;
                        objcontrol.Cola_No_Clientes.Dequeue();
                    }
                    else if (objcontrol.Cola_Preferencial.Count != 0)
                    {
                        atendido = objcontrol.Cola_Preferencial.Peek(); //Cola_Ventanilla_No_Clientes.Enqueue(atendido);//objcontrol.No_Clientes.Add(objcontrol.atendido);
                        ListViewItem fila_1 = new ListViewItem(atendido.Nombre);
                        fila_1.SubItems.Add(atendido.Tramite);
                        fila_1.SubItems.Add(string.Format("{0}", atendido.monto));
                        ListView3.Items.Add(fila_1);
                        if (atendido.Tramite == "Depósito")
                        {
                            dc++;
                            MontoTotal_dc = MontoTotal_dc + atendido.monto;
                        }
                        else
                            if (atendido.Tramite == "Retiro")
                                rc++;
                        MontoTotal_rc = MontoTotal_rc + atendido.monto;
                        objcontrol.Cola_Preferencial.Dequeue();
                    }
                    else if (objcontrol.Cola_Clientes.Count != 0)
                    {
                        atendido = objcontrol.Cola_Clientes.Peek(); //Cola_Ventanilla_No_Clientes.Enqueue(atendido);//objcontrol.No_Clientes.Add(objcontrol.atendido);
                        ListViewItem fila_1 = new ListViewItem(atendido.Nombre);
                        fila_1.SubItems.Add(atendido.Tramite);
                        fila_1.SubItems.Add(string.Format("{0}", atendido.monto));
                        ListView3.Items.Add(fila_1);
                        if (atendido.Tramite == "Depósito")
                        {
                            dp++;
                            MontoTotal_dp = MontoTotal_dp + atendido.monto;
                        }
                        else
                            if (atendido.Tramite == "Retiro")
                                rp++;
                        MontoTotal_rp = MontoTotal_rp + atendido.monto;
                        objcontrol.Cola_Clientes.Dequeue();
                    }
                    break;
            }
        }

        private void CargarColasListBox()
        {
            lst_Clientes.Items.Clear();
            foreach (var usuario in objcontrol.Cola_Clientes)
                lst_Clientes.Items.Add(usuario.Nombre);
            txtUsuario.Clear();

            lst_NoClientes.Items.Clear();
            foreach (var usuario in objcontrol.Cola_No_Clientes)
                lst_NoClientes.Items.Add(usuario.Nombre);
            txtUsuario.Clear();

            lst_Preferencial.Items.Clear();
            foreach (var usuario in objcontrol.Cola_Preferencial)
                lst_Preferencial.Items.Add(usuario.Nombre);
            txtUsuario.Clear();
        }

        private void btn_Reloj_Click(object sender, EventArgs e)
        {
            if (Iniciar == false)
            {
                Iniciar = true;
                btn_Reloj.Text = "Parar";
                Reloj.Enabled = true;
                tiempo = 0;
            }
            else
            {
                Iniciar = false;
                btn_Reloj.Text = "Iniciar";
                Reloj.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objcontrol.Cola_Clientes = new Queue<Persona>();
            objcontrol.Cola_No_Clientes = new Queue<Persona>();
            objcontrol.Cola_Preferencial = new Queue<Persona>();
        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            tiempo++;
            lbl_Reloj.Text = tiempo.ToString();
        }

        void ConfigurarListaPersonasPorSuCondicion()
        {
            //ListView_Preferencial
            ListView1.View = View.Details;
            ListView1.GridLines = true;
            ListView1.Columns.Add("Nombre", 120);
            ListView1.Columns.Add("Tipo de operación", 150);
            ListView1.Columns.Add("Monto", 80);

            //ListView_Clientes
            ListView2.View = View.Details;
            ListView2.GridLines = true;
            ListView2.Columns.Add("Nombre", 120);
            ListView2.Columns.Add("Tipo de operación", 150);
            ListView2.Columns.Add("Monto", 80);

            //ListView_No_Clientes
            ListView3.View = View.Details;
            ListView3.GridLines = true;
            ListView3.Columns.Add("Nombre", 120);
            ListView3.Columns.Add("Tipo de operación", 150);
            ListView3.Columns.Add("Monto", 80);
        }

        private void btn_IngresarUsuario_Click(object sender, EventArgs e)
        {
            Persona pers = new Persona();
            pers.crearPersona(txtUsuario.Text);
            objcontrol.IngresarCliente(pers);
            CargarColasListBox();
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            AtencionCliente();
        }

        private void btn_Reporte1_Click(object sender, EventArgs e)
        {
            if (ListView1.Items.Count > ListView1.Items.Count && ListView1.Items.Count > ListView1.Items.Count)
                MessageBox.Show("La ventanilla con mayor número de atenciones es: CLIENTES");
            else
                if (ListView1.Items.Count > ListView1.Items.Count && ListView1.Items.Count > ListView1.Items.Count)
                    MessageBox.Show("La ventanilla con mayor número de atenciones es: NO CLIENTES");
                else
                    if (ListView1.Items.Count > ListView1.Items.Count && ListView1.Items.Count > ListView1.Items.Count)
                        MessageBox.Show("La ventanilla con mayor número de atenciones es: PREFERENCIAL");
        }

        private void btn_Reporte2_Click(object sender, EventArgs e)
        {
            if (dc + dnc + dp > rc + rnc + rp)
                MessageBox.Show("El tipo de operación más solicitado es: DEPÓSITO");
            else
                if (rc + rnc + rp > dc + dnc + dp)
                    MessageBox.Show("El tipo de operación más solicitado es: RETIRO");
        }

        private void btn_Reporte3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El monto total por depósito en ventanilla preferencial fue de: " + MontoTotal_dp + "\n" + "El monto total por retiro en ventanilla preferencial fue de: " + MontoTotal_rp
               + "\n" + "El monto total por depósito en ventanilla clientes fue de: " + MontoTotal_dc + "\n" + "El monto total por retiro en ventanilla clientes fue de: " + MontoTotal_rc + "\n" +
               "El monto total por depósito en ventanilla no clientes fue de: " + MontoTotal_dnc + "\n" + "El monto total por retiro en ventanilla no clientes fue de: " + MontoTotal_rnc);
        
        }
       
    }
}
