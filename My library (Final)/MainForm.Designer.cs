
namespace My_library__Final_
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdenarPorNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdenarPorApellidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdenarPorIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.préstamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeArriboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arriboDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(111, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem,
            this.agregarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.usuariosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(83, 25);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrdenarPorNombreToolStripMenuItem,
            this.OrdenarPorApellidoToolStripMenuItem,
            this.OrdenarPorIdToolStripMenuItem});
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            // 
            // OrdenarPorNombreToolStripMenuItem
            // 
            this.OrdenarPorNombreToolStripMenuItem.Name = "OrdenarPorNombreToolStripMenuItem";
            this.OrdenarPorNombreToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.OrdenarPorNombreToolStripMenuItem.Text = "Ordenar por nombre";
            this.OrdenarPorNombreToolStripMenuItem.Click += new System.EventHandler(this.OrdenarPorNombreToolStripMenuItem_Click);
            // 
            // OrdenarPorApellidoToolStripMenuItem
            // 
            this.OrdenarPorApellidoToolStripMenuItem.Name = "OrdenarPorApellidoToolStripMenuItem";
            this.OrdenarPorApellidoToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.OrdenarPorApellidoToolStripMenuItem.Text = "Ordenar por apellido";
            // 
            // OrdenarPorIdToolStripMenuItem
            // 
            this.OrdenarPorIdToolStripMenuItem.Name = "OrdenarPorIdToolStripMenuItem";
            this.OrdenarPorIdToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.OrdenarPorIdToolStripMenuItem.Text = "Ordenar por Id";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // préstamosToolStripMenuItem
            // 
            this.préstamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pendientesToolStripMenuItem,
            this.solicitarToolStripMenuItem,
            this.devolverToolStripMenuItem});
            this.préstamosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.préstamosToolStripMenuItem.Name = "préstamosToolStripMenuItem";
            this.préstamosToolStripMenuItem.Size = new System.Drawing.Size(95, 25);
            this.préstamosToolStripMenuItem.Text = "Préstamos";
            // 
            // pendientesToolStripMenuItem
            // 
            this.pendientesToolStripMenuItem.Name = "pendientesToolStripMenuItem";
            this.pendientesToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.pendientesToolStripMenuItem.Text = "Pendientes";
            // 
            // solicitarToolStripMenuItem
            // 
            this.solicitarToolStripMenuItem.Name = "solicitarToolStripMenuItem";
            this.solicitarToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.solicitarToolStripMenuItem.Text = "Solicitar";
            // 
            // devolverToolStripMenuItem
            // 
            this.devolverToolStripMenuItem.Name = "devolverToolStripMenuItem";
            this.devolverToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.devolverToolStripMenuItem.Text = "Devolver";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeArriboToolStripMenuItem,
            this.arriboDeLibrosToolStripMenuItem,
            this.eliminarLibrosToolStripMenuItem,
            this.bajaDeLibrosToolStripMenuItem});
            this.inventarioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(92, 25);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // altaDeArriboToolStripMenuItem
            // 
            this.altaDeArriboToolStripMenuItem.Name = "altaDeArriboToolStripMenuItem";
            this.altaDeArriboToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.altaDeArriboToolStripMenuItem.Text = "Alta de arribo";
            // 
            // arriboDeLibrosToolStripMenuItem
            // 
            this.arriboDeLibrosToolStripMenuItem.Name = "arriboDeLibrosToolStripMenuItem";
            this.arriboDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.arriboDeLibrosToolStripMenuItem.Text = "Arribo de libros";
            // 
            // eliminarLibrosToolStripMenuItem
            // 
            this.eliminarLibrosToolStripMenuItem.Name = "eliminarLibrosToolStripMenuItem";
            this.eliminarLibrosToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.eliminarLibrosToolStripMenuItem.Text = "Eliminar libros ";
            // 
            // bajaDeLibrosToolStripMenuItem
            // 
            this.bajaDeLibrosToolStripMenuItem.Name = "bajaDeLibrosToolStripMenuItem";
            this.bajaDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.bajaDeLibrosToolStripMenuItem.Text = "Baja de libros";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(66, 25);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Enabled = false;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.préstamosToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library v1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrdenarPorNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrdenarPorApellidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrdenarPorIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem préstamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeArriboToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arriboDeLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaDeLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

