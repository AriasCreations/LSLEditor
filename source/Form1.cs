using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

using System.Collections;

using Microsoft.Win32;
using System.Threading;
using System.Reflection;
using System.Globalization;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Printing;
using System.CodeDom.Compiler;
using System.Xml;


// aximp is oude informatie, maar ik laat het er even instaan
// aximp %WINDIR%\System32\shdocvw.dll /out:"d:\temp\AxInterop.SHDocVw.dll" /keyfile:"D:\Documents and Settings\Administrator\Mijn documenten\Mijn keys\Test.snk"
// copieer de TWEE files AxInterop.SHDocVw.dll en SHDocVw.dll in de bin/Debug directory
// referentie maken naar die twee files

//
// Pre build command for using a LSLEditor.rc file containing: About.htm HTML "Resource/About.htm"
//
// "$(DevEnvDir)..\..\SDK\v2.0\bin\rc.exe" /r "$(ProjectDir)$(TargetName).rc"
//
// Project properties Application, resource file

namespace LSLEditor
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Panel panel1;
		private System.ComponentModel.IContainer components = null;
		private System.CodeDom.Compiler.CodeCompiler compiler;
		private bool FullDebug;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.ContextMenuStrip contextMenu1;

		private System.Windows.Forms.ContextMenuStrip mainMenu1;
		private System.Windows.Forms.ToolStripMenuItem menuItem1;
		private System.Windows.Forms.ToolStripMenuItem menuItem2;
		private System.Windows.Forms.ToolStripMenuItem menuItem3;
		private System.Windows.Forms.ToolStripMenuItem menuItem4;
		private System.Windows.Forms.ToolStripMenuItem menuItem5;
		private System.Windows.Forms.ToolStripMenuItem menuItem6;
		private System.Windows.Forms.ToolStripMenuItem menuItem7;
		private System.Windows.Forms.ToolStripMenuItem menuItem8;
		private System.Windows.Forms.ToolStripMenuItem menuItem9;
		private System.Windows.Forms.ToolStripMenuItem menuItem10;
		private System.Windows.Forms.ToolStripMenuItem menuItem11;
		private System.Windows.Forms.ToolStripMenuItem menuItem12;
		private System.Windows.Forms.ToolStripMenuItem menuItem13;
		private System.Windows.Forms.ToolStripMenuItem menuItem14;
		private System.Windows.Forms.ToolStripMenuItem menuItem15;
		private System.Windows.Forms.ToolStripMenuItem menuItem16;
		private System.Windows.Forms.ToolStripMenuItem menuItem17;
		private System.Windows.Forms.ToolStripMenuItem menuItem18;
		private System.Windows.Forms.ToolStripMenuItem menuItem19;
		private System.Windows.Forms.ToolStripMenuItem menuItem20;
		private System.Windows.Forms.ToolStripMenuItem menuItem21;
		private System.Windows.Forms.ToolStripMenuItem menuItem22;
		private System.Windows.Forms.ToolStripMenuItem menuItem23;
		private System.Windows.Forms.ToolStripMenuItem menuItem24;
		private System.Windows.Forms.ToolStripMenuItem menuItem25;
		private System.Windows.Forms.ToolStripMenuItem menuItem26;
		private System.Windows.Forms.ToolStripMenuItem menuItem27;
		private System.Windows.Forms.ToolStripMenuItem menuItem28;
		private System.Windows.Forms.ToolStripMenuItem menuItem29;
		private System.Windows.Forms.ToolStripMenuItem menuItem30;
		private System.Windows.Forms.ToolStripMenuItem menuItem31;
		private System.Windows.Forms.ToolStripMenuItem menuItem32;
		private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Windows.Forms.ToolStripMenuItem menuItem34;
		private System.Windows.Forms.ToolStripMenuItem menuItem35;
		private System.Windows.Forms.ToolStripMenuItem menuItem36;
		private TabPage tabPage1;
		private NumberedTextBox.NumberedTextBoxUC numberedTextBoxUC1;
		private ToolStripMenuItem menuItem37;
		private ToolStripMenuItem menuItem38;
		private ToolStripMenuItem menuItem39;
		private ToolStripMenuItem menuItem41;
		private ToolStripMenuItem menuItem40;
		private ToolStripMenuItem menuItem42;
		private ToolStripMenuItem menuItemUploadScript;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem newToolStripMenuItem;
		private ToolStripMenuItem openToolStripMenuItem;
		private ToolStripSeparator separatorToolStripMenuItem1;
		private ToolStripMenuItem importExampleToolStripMenuItem;
		private ToolStripSeparator separatorToolStripMenuItem2;
		private ToolStripMenuItem uploadYourLSLScriptToolStripMenuItem;
		private ToolStripSeparator separatorToolStripMenuItem3;
		private ToolStripMenuItem saveToolStripMenuItem;
		private ToolStripMenuItem saveAsToolStripMenuItem;
		private ToolStripSeparator toolStripMenuItem1;
		private ToolStripMenuItem pageSetupToolStripMenuItem;
		private ToolStripMenuItem printToolStripMenuItem;
		private ToolStripSeparator toolStripMenuItem2;
		private ToolStripMenuItem copyToClipboardToolStripMenuItem;
		private ToolStripSeparator toolStripMenuItem3;
		private ToolStripMenuItem exitToolStripMenuItem;
		private ToolStripMenuItem editToolStripMenuItem;
		private ToolStripMenuItem undoToolStripMenuItem;
		private ToolStripMenuItem redoToolStripMenuItem;
		private ToolStripSeparator toolStripMenuItem4;
		private ToolStripMenuItem cutToolStripMenuItem;
		private ToolStripMenuItem copyToolStripMenuItem;
		private ToolStripMenuItem pasteToolStripMenuItem;
		private ToolStripMenuItem deleteToolStripMenuItem;
		private ToolStripMenuItem selectAllToolStripMenuItem;
		private ToolStripSeparator toolStripMenuItem5;
		private ToolStripMenuItem advancedToolStripMenuItem;
		private ToolStripMenuItem formatDocumentToolStripMenuItem;
		private ToolStripMenuItem formatSelectionToolStripMenuItem;
		private ToolStripMenuItem wordWrapToolStripMenuItem;
		private ToolStripMenuItem compilerToolStripMenuItem;
		private ToolStripMenuItem startToolStripMenuItem;
		private ToolStripMenuItem compilerWindowToolStripMenuItem;
		private ToolStripSeparator toolStripMenuItem6;
		private ToolStripMenuItem propertiesToolStripMenuItem;
		private ToolStripMenuItem helpToolStripMenuItem;
		private ToolStripMenuItem indexToolStripMenuItem;
		private ToolStripSeparator toolStripMenuItem7;
		private ToolStripMenuItem checkForUpdatesToolStripMenuItem;
		private ToolStripSeparator toolStripMenuItem8;
		private ToolStripMenuItem aboutToolStripMenuItem;
		private TabControl tabControl2;
		private TabPage tabPage2;
		private TabPage tabPage3;
		private StatusStrip statusStrip2;
		private System.Windows.Forms.ToolStripMenuItem menuItem33;

		public Form1(string[] args)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			Start(args);
		}



		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}


        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separatorToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.importExampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separatorToolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.uploadYourLSLScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separatorToolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.advancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compilerWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(592, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.separatorToolStripMenuItem1,
            this.importExampleToolStripMenuItem,
            this.separatorToolStripMenuItem2,
            this.uploadYourLSLScriptToolStripMenuItem,
            this.separatorToolStripMenuItem3,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.pageSetupToolStripMenuItem,
            this.printToolStripMenuItem,
            this.toolStripMenuItem2,
            this.copyToClipboardToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(305, 34);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.menuItem11_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(305, 34);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // separatorToolStripMenuItem1
            // 
            this.separatorToolStripMenuItem1.Name = "separatorToolStripMenuItem1";
            this.separatorToolStripMenuItem1.Size = new System.Drawing.Size(302, 6);
            // 
            // importExampleToolStripMenuItem
            // 
            this.importExampleToolStripMenuItem.Name = "importExampleToolStripMenuItem";
            this.importExampleToolStripMenuItem.Size = new System.Drawing.Size(305, 34);
            this.importExampleToolStripMenuItem.Text = "Import Example...";
            this.importExampleToolStripMenuItem.Click += new System.EventHandler(this.menuItem40_Click);
            // 
            // separatorToolStripMenuItem2
            // 
            this.separatorToolStripMenuItem2.Name = "separatorToolStripMenuItem2";
            this.separatorToolStripMenuItem2.Size = new System.Drawing.Size(302, 6);
            // 
            // uploadYourLSLScriptToolStripMenuItem
            // 
            this.uploadYourLSLScriptToolStripMenuItem.Name = "uploadYourLSLScriptToolStripMenuItem";
            this.uploadYourLSLScriptToolStripMenuItem.Size = new System.Drawing.Size(305, 34);
            this.uploadYourLSLScriptToolStripMenuItem.Text = "Upload Your LSL Script...";
            this.uploadYourLSLScriptToolStripMenuItem.Click += new System.EventHandler(this.menuItemUploadScript_Click);
            // 
            // separatorToolStripMenuItem3
            // 
            this.separatorToolStripMenuItem3.Name = "separatorToolStripMenuItem3";
            this.separatorToolStripMenuItem3.Size = new System.Drawing.Size(302, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(305, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.menuItem13_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(305, 34);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(302, 6);
            // 
            // pageSetupToolStripMenuItem
            // 
            this.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
            this.pageSetupToolStripMenuItem.Size = new System.Drawing.Size(305, 34);
            this.pageSetupToolStripMenuItem.Text = "Page Setup...";
            this.pageSetupToolStripMenuItem.Click += new System.EventHandler(this.menuItem35_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(305, 34);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.menuItem34_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(302, 6);
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(305, 34);
            this.copyToClipboardToolStripMenuItem.Text = "Copy To Clipboard";
            this.copyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.menuItem31_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(302, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(305, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripMenuItem4,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.toolStripMenuItem5,
            this.advancedToolStripMenuItem,
            this.wordWrapToolStripMenuItem,
            this.compilerToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(264, 34);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.menuItem24_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(264, 34);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.menuItem23_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(261, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(264, 34);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.menuItem22_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(264, 34);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.menuItem21_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(264, 34);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.menuItem20_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(264, 34);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.menuItem26_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(264, 34);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.menuItem28_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(261, 6);
            // 
            // advancedToolStripMenuItem
            // 
            this.advancedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatDocumentToolStripMenuItem,
            this.formatSelectionToolStripMenuItem});
            this.advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
            this.advancedToolStripMenuItem.Size = new System.Drawing.Size(264, 34);
            this.advancedToolStripMenuItem.Text = "Advanced";
            // 
            // formatDocumentToolStripMenuItem
            // 
            this.formatDocumentToolStripMenuItem.Name = "formatDocumentToolStripMenuItem";
            this.formatDocumentToolStripMenuItem.Size = new System.Drawing.Size(259, 34);
            this.formatDocumentToolStripMenuItem.Text = "Format Document";
            this.formatDocumentToolStripMenuItem.Click += new System.EventHandler(this.menuItem38_Click);
            // 
            // formatSelectionToolStripMenuItem
            // 
            this.formatSelectionToolStripMenuItem.Name = "formatSelectionToolStripMenuItem";
            this.formatSelectionToolStripMenuItem.Size = new System.Drawing.Size(259, 34);
            this.formatSelectionToolStripMenuItem.Text = "Format Selection";
            this.formatSelectionToolStripMenuItem.Click += new System.EventHandler(this.menuItem39_Click);
            // 
            // wordWrapToolStripMenuItem
            // 
            this.wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            this.wordWrapToolStripMenuItem.Size = new System.Drawing.Size(264, 34);
            this.wordWrapToolStripMenuItem.Text = "Word Wrap";
            this.wordWrapToolStripMenuItem.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // compilerToolStripMenuItem
            // 
            this.compilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.compilerWindowToolStripMenuItem,
            this.toolStripMenuItem6,
            this.propertiesToolStripMenuItem});
            this.compilerToolStripMenuItem.Name = "compilerToolStripMenuItem";
            this.compilerToolStripMenuItem.Size = new System.Drawing.Size(264, 34);
            this.compilerToolStripMenuItem.Text = "Compiler";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.startToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.menuItem14_Click);
            // 
            // compilerWindowToolStripMenuItem
            // 
            this.compilerWindowToolStripMenuItem.Name = "compilerWindowToolStripMenuItem";
            this.compilerWindowToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.compilerWindowToolStripMenuItem.Text = "Compiler Window";
            this.compilerWindowToolStripMenuItem.Click += new System.EventHandler(this.menuItem33_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(254, 6);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.propertiesToolStripMenuItem.Text = "Properties...";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.menuItem30_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.indexToolStripMenuItem,
            this.toolStripMenuItem7,
            this.checkForUpdatesToolStripMenuItem,
            this.toolStripMenuItem8,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.indexToolStripMenuItem.Text = "Index";
            this.indexToolStripMenuItem.Click += new System.EventHandler(this.menuItem16_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(272, 6);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.checkForUpdatesToolStripMenuItem.Text = "Check For Updates...";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.menuItem18_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(272, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 320);
            this.panel1.TabIndex = 2;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(592, 320);
            this.tabControl2.TabIndex = 1;
            this.tabControl2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseDown);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.statusStrip2);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(584, 282);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "New";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(200, 100);
            this.tabPage3.TabIndex = 0;
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip2.Location = new System.Drawing.Point(3, 247);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(578, 32);
            this.statusStrip2.TabIndex = 0;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(24, 25);
            this.toolStripStatusLabel1.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(9, 24);
            this.ClientSize = new System.Drawing.Size(592, 353);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "LSL-Editor";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void Start(string[] args)
		{
			this.FullDebug = true;

			Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US", false);
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US", false);

			string strVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
			this.Text += " " + strVersion;

			// load the keywords and colors, give handle to codecompletion listBox
			XmlDocument conf = new XmlDocument();
			conf.LoadXml("ConfLSL.xml");
			//this.numberedTextBoxUC1.TextBox.Init(this,conf);

			if (args.Length == 0)
			{
				//this.numberedTextBoxUC1.TextBox.GetExampleFile();
				this.saveFileDialog1.FileName = "new.lsl";
				this.menuItem13.Text = "Save new.lsl";
				this.menuItem13.Enabled = false;
			}
			else
			{
				this.numberedTextBoxUC1.TextBox.LoadFile(args[0]);
				this.tabControl1.TabPages[0].Text = Path.GetFileName(args[0]);
				this.menuItem13.Text = "Save " + Path.GetFileName(args[0]);
				this.menuItem13.Enabled = true;
				this.saveFileDialog1.FileName = args[0];
			}
			this.numberedTextBoxUC1.TextBox.ToolTipping = true;
			this.numberedTextBoxUC1.TextBox.Dirty = false;
		}

		// close application
		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		// reading file
		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			if (this.numberedTextBoxUC1.TextBox.Dirty)
			{
				DialogResult dialogResult = MessageBox.Show(this, @"Save """ + this.tabControl1.TabPages[0].Text + @"""?", "cap", MessageBoxButtons.YesNoCancel);
				if (dialogResult == DialogResult.Yes)
					dialogResult = SaveCurrentFile();
				if (dialogResult == DialogResult.Cancel)
					return;
			}
			this.openFileDialog1.Filter = "Secondlife script files (*.lsl)|*.lsl|All files (*.*)|*.*";
			if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				if (File.Exists(this.openFileDialog1.FileName))
				{
					this.numberedTextBoxUC1.TextBox.LoadFile(this.openFileDialog1.FileName);
					this.numberedTextBoxUC1.TextBox.Dirty = false;
					this.saveFileDialog1.FileName = this.openFileDialog1.FileName;
					this.tabControl1.TabPages[0].Text = Path.GetFileName(this.openFileDialog1.FileName);

					this.menuItem13.Text = "Save " + Path.GetFileName(this.openFileDialog1.FileName);
					this.menuItem13.Enabled = true;
					this.saveFileDialog1.FileName = this.openFileDialog1.FileName;
				}
			}
		}

		// save current file
		private DialogResult SaveCurrentFile()
		{
			this.saveFileDialog1.Filter = "Secondlife script files (*.lsl)|*.lsl|All files (*.*)|*.*";
			DialogResult dialogresult = this.saveFileDialog1.ShowDialog();
			if (dialogresult == DialogResult.OK)
			{
				this.numberedTextBoxUC1.TextBox.SaveFile(this.saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
				this.tabControl1.TabPages[0].Text = Path.GetFileName(this.saveFileDialog1.FileName);
				this.menuItem13.Text = "Save " + Path.GetFileName(this.saveFileDialog1.FileName);
				this.menuItem13.Enabled = true;
				this.numberedTextBoxUC1.TextBox.Dirty = false;
			}
			return dialogresult;
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			SaveCurrentFile();
		}

		// about
		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			//About about = new About(this);
			//about.ShowDialog(this);
		}

		// toggle word wrap
		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			this.menuItem9.Checked = !this.menuItem9.Checked;
			this.numberedTextBoxUC1.TextBox.WordWrap = (this.menuItem9.Checked);
		}

		private void StartCompiler()
		{
			// ZNI note: 
			// Old compiler is deprecated and obsolete. Microsoft now recommends to use Microsoft.CSharp.CSharpCodeProvider.
			// TODO: Add this in.
			//compiler = Microsoft.CSharp.CSharpCodeProvider.CreateProvider("csharp").CreateCompiler();
			//compiler = new System.CodeDom.Compiler.ICodeCompiler(this.FullDebug, "ConfLSL.xml", this.numberedTextBoxUC1.TextBox.Text);
			//if (compiler.CompilerErrors != null)
			//{
			//	MessageBox.Show(compiler.CompilerErrors, "compiler errors");
			//	return;
			//}

			if (this.menuItem33.Checked)
			{
			//	compiler.ShowDialog(this);
			}
			else
			{
				TabPage tabPage = null;
				for (int intI = 0; intI < this.tabControl1.TabPages.Count; intI++)
				{
					if (this.tabControl1.TabPages[intI].Text == "Compiler")
					{
						tabPage = this.tabControl1.TabPages[intI];
						tabPage.Controls.Clear();
						this.tabControl1.SelectedIndex = intI;
						break;
					}
				}
				if (tabPage == null)
				{
					tabPage = new TabPage("Compiler");
					this.tabControl1.TabPages.Add(tabPage);
					this.tabControl1.SelectedIndex = this.tabControl1.TabCount - 1;
				}
				//tabPage.Controls.Add(compiler.Controls[0]);
			}
		}

		// compiler
		private void menuItem14_Click(object sender, System.EventArgs e)
		{
			StartCompiler();
		}

		// Empty current script
		private void menuItem11_Click(object sender, System.EventArgs e)
		{
			this.tabControl1.TabPages[0].Text = "New";
			this.saveFileDialog1.FileName = "new.lsl";
			this.menuItem13.Text = "Save new.lsl";
			this.menuItem13.Enabled = false;
			this.numberedTextBoxUC1.TextBox.Clear();
			this.numberedTextBoxUC1.TextBox.SelectionStart = 0;
			this.numberedTextBoxUC1.TextBox.SelectionLength = 0;
			this.numberedTextBoxUC1.TextBox.SelectionColor = Color.Black;
			this.numberedTextBoxUC1.TextBox.Dirty = false;
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			try
			{
				RegistryKey regKey = Registry.CurrentUser.OpenSubKey(@"software\hwh\lsleditor");
				if (regKey != null)
				{
					this.Width = (int)regKey.GetValue("Width");
					this.Height = (int)regKey.GetValue("Height");
					this.Left = (int)regKey.GetValue("Left");
					this.Top = (int)regKey.GetValue("Top");
					this.numberedTextBoxUC1.TextBox.WordWrap = (regKey.GetValue("WordWrap").ToString() == "True");
					this.menuItem9.Checked = this.numberedTextBoxUC1.TextBox.WordWrap;
					this.menuItem33.Checked = (regKey.GetValue("CompilerInWindow").ToString() == "True");
					regKey.GetValue("Unknown").ToString();
					this.FullDebug = true;
					this.menuItemUploadScript.Enabled = true;
				}
			}
			catch
			{
			}
			//this.Activate();
		}

		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			RegistryKey regKey = Registry.CurrentUser.CreateSubKey(@"software\hwh\lsleditor");
			if (regKey != null)
			{
				regKey.SetValue("Width", this.Width);
				regKey.SetValue("Height", this.Height);
				regKey.SetValue("Top", this.Top);
				regKey.SetValue("Left", this.Left);
				regKey.SetValue("WordWrap", this.numberedTextBoxUC1.TextBox.WordWrap);
				regKey.SetValue("CompilerInWindow", this.menuItem33.Checked);
				regKey.Flush();
				regKey.Close();
			}
			if (this.numberedTextBoxUC1.TextBox.Dirty)
			{
				DialogResult dialogResult = MessageBox.Show(this, @"Save """ + this.tabControl1.TabPages[0].Text + @"""?", "cap", MessageBoxButtons.YesNoCancel);
				if (dialogResult == DialogResult.Yes)
					dialogResult = SaveCurrentFile();
				e.Cancel = (dialogResult == DialogResult.Cancel);
			}
		}

		// F1
		private void ShowHelp()
		{
			/*string strKeyWord = this.numberedTextBoxUC1.TextBox.GetCurrentKeyWord(false);

			string strUrl = this.numberedTextBoxUC1.TextBox.HelpUrl + "wakka.php?wakka=" + strKeyWord;

			if (strKeyWord == "")
				strKeyWord = "Help";

			ShowWebBrowser(strKeyWord, strUrl);*/
		}

		// show context menu for tab headers
		private void tabControl1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				for (int intI = 1; intI < tabControl1.TabCount; intI++)
				{
					Rectangle rt = tabControl1.GetTabRect(intI);
					if (e.X > rt.Left && e.X < rt.Right
						&& e.Y > rt.Top && e.Y < rt.Bottom)
					{
						this.contextMenu1.Show(this.tabControl1, new Point(e.X, e.Y));
					}
				}
			}
		}

		// close tab
		private void menuItem10_Click(object sender, System.EventArgs e)
		{
			if (this.tabControl1.SelectedIndex > 0)
				this.tabControl1.TabPages.RemoveAt(this.tabControl1.SelectedIndex);
		}

		private void menuItem13_Click(object sender, System.EventArgs e)
		{
			// save as current file
			this.numberedTextBoxUC1.TextBox.SaveFile(this.saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
			this.numberedTextBoxUC1.TextBox.Dirty = false;
		}

		private void menuItem16_Click(object sender, System.EventArgs e)
		{
			ShowHelp();
		}

		private void menuItem18_Click(object sender, System.EventArgs e)
		{
			//ShowWebBrowser("Check for Updates", this.numberedTextBoxUC1.TextBox.UpdateUrl);
		}

		private void menuItem22_Click(object sender, System.EventArgs e)
		{
			this.numberedTextBoxUC1.TextBox.Cut();
		}

		private void menuItem21_Click(object sender, System.EventArgs e)
		{
			this.numberedTextBoxUC1.TextBox.Copy();
		}

		private void menuItem20_Click(object sender, System.EventArgs e)
		{
			this.numberedTextBoxUC1.TextBox.Paste();
		}

		private void menuItem26_Click(object sender, System.EventArgs e)
		{
			if (this.numberedTextBoxUC1.TextBox.SelectedText == "")
				this.numberedTextBoxUC1.TextBox.SelectionLength = 1;
			this.numberedTextBoxUC1.TextBox.SelectedText = "";
		}

		private void menuItem28_Click(object sender, System.EventArgs e)
		{
			this.numberedTextBoxUC1.TextBox.SelectAll();
		}

		private void menuItem24_Click(object sender, System.EventArgs e)
		{
			//this.numberedTextBoxUC1.TextBox.UndoPlus();
		}

		private void menuItem23_Click(object sender, System.EventArgs e)
		{
			this.numberedTextBoxUC1.TextBox.Redo();
		}

		private void menuItem30_Click(object sender, System.EventArgs e)
		{
			/*SimProperties props = new SimProperties();
			props.Icon = this.Icon;
			props.ShowDialog(this);*/
		}

		private void menuItem31_Click(object sender, System.EventArgs e)
		{
			this.numberedTextBoxUC1.TextBox.ToClipBoard();
		}

		private void menuItem33_Click(object sender, System.EventArgs e)
		{
			this.menuItem33.Checked = !this.menuItem33.Checked;
		}

		private void menuItem35_Click(object sender, System.EventArgs e)
		{
			PrintDocument docPrn = new PrintDocument();
			docPrn.DocumentName = this.saveFileDialog1.FileName;
			this.pageSetupDialog1.Document = docPrn;
			this.pageSetupDialog1.ShowDialog();
		}

		private void menuItem34_Click(object sender, System.EventArgs e)
		{
			this.printDialog1.AllowPrintToFile = true;
			PrintDocument docPrn = new PrintDocument();
			docPrn.DocumentName = this.saveFileDialog1.FileName;
			this.printDialog1.Document = docPrn;
			if (this.printDialog1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					docPrn.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);
					docPrn.Print();
				}
				catch
				{
					MessageBox.Show("Error While Printing", "Print Error");
				}
			}
		}

		private void printDoc_PrintPage(Object sender, PrintPageEventArgs e)
		{
			this.numberedTextBoxUC1.TextBox.Print(0, this.numberedTextBoxUC1.TextBox.Text.Length, e);
		}

		private void menuItem38_Click(object sender, EventArgs e)
		{
			// Format Document
			AutoFormatter autoFormatter = new AutoFormatter();
			//this.numberedTextBoxUC1.TextBox.Text =
			//	autoFormatter.ApplyFormatting(this.numberedTextBoxUC1.TextBox.Text);
		}

		private void menuItem39_Click(object sender, EventArgs e)
		{
			// Format Selection
			AutoFormatter autoFormatter = new AutoFormatter();
			//this.numberedTextBoxUC1.TextBox.SelectedText =
			//	autoFormatter.ApplyFormatting(this.numberedTextBoxUC1.TextBox.SelectedText);
		}

		private void menuItem40_Click(object sender, EventArgs e)
		{
			//ShowWebBrowser("Import Examples", this.numberedTextBoxUC1.TextBox.ExamplesUrl);
		}

		private void ShowWebBrowser(string strTabName, string strUrl)
		{
			TabPage tabPage = new TabPage(strTabName);

			WebBrowser axWebBrowser1 = new WebBrowser();
			tabPage.Controls.Add(axWebBrowser1);
			this.tabControl1.TabPages.Add(tabPage);
			this.tabControl1.SelectedIndex = this.tabControl1.TabCount - 1;

			axWebBrowser1.Dock = DockStyle.Fill;
			axWebBrowser1.StatusTextChanged += new EventHandler(axWebBrowser1_StatusTextChanged);
			axWebBrowser1.Navigating += new WebBrowserNavigatingEventHandler(axWebBrowser1_Navigating);
			axWebBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(axWebBrowser1_DocumentCompleted);
			axWebBrowser1.Navigate(strUrl);
		}

		void axWebBrowser1_StatusTextChanged(object sender, EventArgs e)
		{
			WebBrowser axWebBrowser1 = sender as WebBrowser;
			this.toolStripStatusLabel1.Text = axWebBrowser1.StatusText;
		}


		void axWebBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
		{
			string strUrl = e.Url.ToString();
			if (strUrl.EndsWith(".lsl"))
			{
				e.Cancel = true;
				if (MessageBox.Show("Import LSL script?", "Import script", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
					return;

				WebBrowser axWebBrowser1 = sender as WebBrowser;
				axWebBrowser1.Stop();

				// download the url
				this.numberedTextBoxUC1.TextBox.LoadFile(strUrl);
				this.numberedTextBoxUC1.TextBox.Dirty = true;

				// Delete webbrowser?
				// axWebBrowser1.Dispose();
				// this.tabControl1.TabPages.RemoveAt(this.tabControl1.TabCount - 1);

				int intI = strUrl.LastIndexOf("/");
				if (intI > 0)
				{
					string strName = strUrl.Substring(intI + 1);
					this.tabControl1.TabPages[0].Text = strName;
					this.menuItem13.Text = "Save " + strName;
					this.menuItem13.Enabled = false;
					this.saveFileDialog1.FileName = strName;
				}

				this.tabControl1.SelectedIndex = 0;
			}
		}

		void axWebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			/*WebBrowser axWebBrowser1 = sender as WebBrowser;
			if (e.Url.ToString() == this.numberedTextBoxUC1.TextBox.UploadUrl)
			{
				HtmlElement element = axWebBrowser1.Document.GetElementById("SourceCode");
				if (element != null)
				{
					//if(element.InnerText.Trim()=="")
					element.InnerText = this.numberedTextBoxUC1.TextBox.Text;

					// Makepictures
					Size oldSize = this.Size;
					this.Size = new Size(640, 480);

					Bitmap bitmap;
					ImageManipulation.GetBitmapFromControl helper = new ImageManipulation.GetBitmapFromControl();

					this.tabControl1.SelectedIndex = 0;
					bitmap = helper.GetOctreeQuantizedBitmap(this, false);
					bitmap.Save(@"d:\temp\test1.gif", ImageFormat.Gif);

					element = axWebBrowser1.Document.GetElementById("File1");
					if (element != null)
					{
						element.SetAttribute("value", @"d:\temp\test1.gif");
						element.OuterHtml = @"<input name=""File1"" type=""file"" id=""File1"" size=""80"" value=""test""/>";
					}

					if (this.tabControl1.TabPages[1].Text.Contains("Compiler"))
					{
						this.tabControl1.SelectedIndex = 1;
						bitmap = helper.GetOctreeQuantizedBitmap(this, false);
						bitmap.Save(@"d:\temp\test2.gif", ImageFormat.Gif);

						element = axWebBrowser1.Document.GetElementById("File2");
						if (element != null)
							element.SetAttribute("value", @"d:\temp\test2.gif");
					}

					this.tabControl1.SelectedIndex = this.tabControl1.TabPages.Count - 1;
					this.Size = oldSize;
				}
			}*/
		}

		private void UploadScript()
		{
			//ShowWebBrowser("Upload", this.numberedTextBoxUC1.TextBox.UploadUrl);

			ArrayList pictures = new ArrayList();
			Size oldSize = this.Size;
			int intSelectedTab = this.tabControl1.SelectedIndex;
			this.Size = new Size(640, 480);

			Bitmap bitmap;
			//ImageManipulation.GetBitmapFromControl helper = new ImageManipulation.GetBitmapFromControl();

			this.tabControl1.SelectedIndex = 0;
			//bitmap = helper.GetOctreeQuantizedBitmap(this, false);
			string strTempFileName = Path.GetTempFileName() + ".gif";
			//bitmap.Save(strTempFileName, ImageFormat.Gif);
			pictures.Add(strTempFileName);

			for (int intI = 1; intI < this.tabControl1.TabPages.Count; intI++)
			{
				if (this.tabControl1.TabPages[intI].Text.Contains("Compiler"))
				{
					this.tabControl1.SelectedIndex = intI;
					//bitmap = helper.GetOctreeQuantizedBitmap(this, false);
					strTempFileName = Path.GetTempFileName() + ".gif";
					//bitmap.Save(strTempFileName, ImageFormat.Gif);
					pictures.Add(strTempFileName);
					break;
				}
			}
			this.tabControl1.SelectedIndex = intSelectedTab;
			this.Size = oldSize;

			/*UploadExamle u = new UploadExamle(
				Path.GetFileName(this.saveFileDialog1.FileName),
				this.numberedTextBoxUC1.TextBox.UploadUrl,
				this.numberedTextBoxUC1.TextBox.Text,
				pictures);
			u.ShowDialog(this);*/

			// cleanup
			foreach (string strFileName in pictures)
			{
				File.Delete(strFileName);
			}
		}

		private void menuItemUploadScript_Click(object sender, EventArgs e)
		{
			UploadScript();
		}
	}
}
