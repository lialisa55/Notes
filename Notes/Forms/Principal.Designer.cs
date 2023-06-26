
using Notes.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace Notes
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbBackup = new System.Windows.Forms.ToolStripLabel();
            this.tsbRestore = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.tsbBackup,
            this.tsbRestore});
            this.toolStrip1.Location = new System.Drawing.Point(330, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(47, 450);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Notes.Properties.Resources.adicionar_botao;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(44, 20);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbBackup
            // 
            this.tsbBackup.Name = "tsbBackup";
            this.tsbBackup.Size = new System.Drawing.Size(44, 15);
            this.tsbBackup.Text = "Backup";
            this.tsbBackup.Click += new System.EventHandler(this.tsbBackup_Click);
            // 
            // tsbRestore
            // 
            this.tsbRestore.Name = "tsbRestore";
            this.tsbRestore.Size = new System.Drawing.Size(44, 15);
            this.tsbRestore.Text = "Restore";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public override bool Equals(object obj)
            {
            return obj is Principal principal &&
                   CanRaiseEvents == principal.CanRaiseEvents &&
                   EqualityComparer<EventHandlerList>.Default.Equals(Events, principal.Events) &&
                   EqualityComparer<ISite>.Default.Equals(Site, principal.Site) &&
                   EqualityComparer<IContainer>.Default.Equals(Container, principal.Container) &&
                   DesignMode == principal.DesignMode &&
                   EqualityComparer<AccessibleObject>.Default.Equals(AccessibilityObject, principal.AccessibilityObject) &&
                   AccessibleDefaultActionDescription == principal.AccessibleDefaultActionDescription &&
                   AccessibleDescription == principal.AccessibleDescription &&
                   AccessibleName == principal.AccessibleName &&
                   AccessibleRole == principal.AccessibleRole &&
                   AllowDrop == principal.AllowDrop &&
                   Anchor == principal.Anchor &&
                   AutoSize == principal.AutoSize &&
                   EqualityComparer<Point>.Default.Equals(AutoScrollOffset, principal.AutoScrollOffset) &&
                   EqualityComparer<LayoutEngine>.Default.Equals(LayoutEngine, principal.LayoutEngine) &&
                   EqualityComparer<Color>.Default.Equals(BackColor, principal.BackColor) &&
                   EqualityComparer<Image>.Default.Equals(BackgroundImage, principal.BackgroundImage) &&
                   BackgroundImageLayout == principal.BackgroundImageLayout &&
                   EqualityComparer<BindingContext>.Default.Equals(BindingContext, principal.BindingContext) &&
                   Bottom == principal.Bottom &&
                   EqualityComparer<Rectangle>.Default.Equals(Bounds, principal.Bounds) &&
                   CanFocus == principal.CanFocus &&
                   CanRaiseEvents == principal.CanRaiseEvents &&
                   CanSelect == principal.CanSelect &&
                   Capture == principal.Capture &&
                   CausesValidation == principal.CausesValidation &&
                   EqualityComparer<Rectangle>.Default.Equals(ClientRectangle, principal.ClientRectangle) &&
                   EqualityComparer<Size>.Default.Equals(ClientSize, principal.ClientSize) &&
                   CompanyName == principal.CompanyName &&
                   ContainsFocus == principal.ContainsFocus &&
                   EqualityComparer<ContextMenu>.Default.Equals(ContextMenu, principal.ContextMenu) &&
                   EqualityComparer<ContextMenuStrip>.Default.Equals(ContextMenuStrip, principal.ContextMenuStrip) &&
                   EqualityComparer<Control.ControlCollection>.Default.Equals(Controls, principal.Controls) &&
                   Created == principal.Created &&
                   EqualityComparer<CreateParams>.Default.Equals(CreateParams, principal.CreateParams) &&
                   EqualityComparer<Cursor>.Default.Equals(Cursor, principal.Cursor) &&
                   EqualityComparer<ControlBindingsCollection>.Default.Equals(DataBindings, principal.DataBindings) &&
                   EqualityComparer<Cursor>.Default.Equals(DefaultCursor, principal.DefaultCursor) &&
                   EqualityComparer<Padding>.Default.Equals(DefaultMargin, principal.DefaultMargin) &&
                   EqualityComparer<Size>.Default.Equals(DefaultMaximumSize, principal.DefaultMaximumSize) &&
                   EqualityComparer<Size>.Default.Equals(DefaultMinimumSize, principal.DefaultMinimumSize) &&
                   EqualityComparer<Padding>.Default.Equals(DefaultPadding, principal.DefaultPadding) &&
                   EqualityComparer<Size>.Default.Equals(DefaultSize, principal.DefaultSize) &&
                   DeviceDpi == principal.DeviceDpi &&
                   EqualityComparer<Rectangle>.Default.Equals(DisplayRectangle, principal.DisplayRectangle) &&
                   IsDisposed == principal.IsDisposed &&
                   Disposing == principal.Disposing &&
                   Dock == principal.Dock &&
                   DoubleBuffered == principal.DoubleBuffered &&
                   Enabled == principal.Enabled &&
                   Focused == principal.Focused &&
                   EqualityComparer<Font>.Default.Equals(Font, principal.Font) &&
                   FontHeight == principal.FontHeight &&
                   EqualityComparer<Color>.Default.Equals(ForeColor, principal.ForeColor) &&
                   EqualityComparer<IntPtr>.Default.Equals(Handle, principal.Handle) &&
                   HasChildren == principal.HasChildren &&
                   Height == principal.Height &&
                   IsHandleCreated == principal.IsHandleCreated &&
                   InvokeRequired == principal.InvokeRequired &&
                   IsAccessible == principal.IsAccessible &&
                   IsMirrored == principal.IsMirrored &&
                   Left == principal.Left &&
                   EqualityComparer<Point>.Default.Equals(Location, principal.Location) &&
                   EqualityComparer<Padding>.Default.Equals(Margin, principal.Margin) &&
                   EqualityComparer<Size>.Default.Equals(MaximumSize, principal.MaximumSize) &&
                   EqualityComparer<Size>.Default.Equals(MinimumSize, principal.MinimumSize) &&
                   Name == principal.Name &&
                   EqualityComparer<Control>.Default.Equals(Parent, principal.Parent) &&
                   ProductName == principal.ProductName &&
                   ProductVersion == principal.ProductVersion &&
                   RecreatingHandle == principal.RecreatingHandle &&
                   EqualityComparer<Region>.Default.Equals(Region, principal.Region) &&
                   RenderRightToLeft == principal.RenderRightToLeft &&
                   ResizeRedraw == principal.ResizeRedraw &&
                   Right == principal.Right &&
                   RightToLeft == principal.RightToLeft &&
                   ScaleChildren == principal.ScaleChildren &&
                   EqualityComparer<ISite>.Default.Equals(Site, principal.Site) &&
                   EqualityComparer<Size>.Default.Equals(Size, principal.Size) &&
                   TabIndex == principal.TabIndex &&
                   TabStop == principal.TabStop &&
                   EqualityComparer<object>.Default.Equals(Tag, principal.Tag) &&
                   Text == principal.Text &&
                   Top == principal.Top &&
                   EqualityComparer<Control>.Default.Equals(TopLevelControl, principal.TopLevelControl) &&
                   ShowKeyboardCues == principal.ShowKeyboardCues &&
                   ShowFocusCues == principal.ShowFocusCues &&
                   UseWaitCursor == principal.UseWaitCursor &&
                   Visible == principal.Visible &&
                   Width == principal.Width &&
                   EqualityComparer<IWindowTarget>.Default.Equals(WindowTarget, principal.WindowTarget) &&
                   EqualityComparer<Size>.Default.Equals(PreferredSize, principal.PreferredSize) &&
                   EqualityComparer<Padding>.Default.Equals(Padding, principal.Padding) &&
                   CanEnableIme == principal.CanEnableIme &&
                   DefaultImeMode == principal.DefaultImeMode &&
                   ImeMode == principal.ImeMode &&
                   ImeModeBase == principal.ImeModeBase &&
                   AutoScroll == principal.AutoScroll &&
                   EqualityComparer<Size>.Default.Equals(AutoScrollMargin, principal.AutoScrollMargin) &&
                   EqualityComparer<Point>.Default.Equals(AutoScrollPosition, principal.AutoScrollPosition) &&
                   EqualityComparer<Size>.Default.Equals(AutoScrollMinSize, principal.AutoScrollMinSize) &&
                   EqualityComparer<CreateParams>.Default.Equals(CreateParams, principal.CreateParams) &&
                   EqualityComparer<Rectangle>.Default.Equals(DisplayRectangle, principal.DisplayRectangle) &&
                   HScroll == principal.HScroll &&
                   EqualityComparer<HScrollProperties>.Default.Equals(HorizontalScroll, principal.HorizontalScroll) &&
                   VScroll == principal.VScroll &&
                   EqualityComparer<VScrollProperties>.Default.Equals(VerticalScroll, principal.VerticalScroll) &&
                   EqualityComparer<DockPaddingEdges>.Default.Equals(DockPadding, principal.DockPadding) &&
                   EqualityComparer<SizeF>.Default.Equals(AutoScaleDimensions, principal.AutoScaleDimensions) &&
                   EqualityComparer<SizeF>.Default.Equals(AutoScaleFactor, principal.AutoScaleFactor) &&
                   AutoScaleMode == principal.AutoScaleMode &&
                   AutoValidate == principal.AutoValidate &&
                   EqualityComparer<BindingContext>.Default.Equals(BindingContext, principal.BindingContext) &&
                   CanEnableIme == principal.CanEnableIme &&
                   EqualityComparer<Control>.Default.Equals(ActiveControl, principal.ActiveControl) &&
                   EqualityComparer<CreateParams>.Default.Equals(CreateParams, principal.CreateParams) &&
                   EqualityComparer<SizeF>.Default.Equals(CurrentAutoScaleDimensions, principal.CurrentAutoScaleDimensions) &&
                   EqualityComparer<Form>.Default.Equals(ParentForm, principal.ParentForm) &&
                   EqualityComparer<IButtonControl>.Default.Equals(AcceptButton, principal.AcceptButton) &&
                   EqualityComparer<Form>.Default.Equals(ActiveMdiChild, principal.ActiveMdiChild) &&
                   AllowTransparency == principal.AllowTransparency &&
                   AutoScale == principal.AutoScale &&
                   EqualityComparer<Size>.Default.Equals(AutoScaleBaseSize, principal.AutoScaleBaseSize) &&
                   AutoScroll == principal.AutoScroll &&
                   AutoSize == principal.AutoSize &&
                   AutoSizeMode == principal.AutoSizeMode &&
                   AutoValidate == principal.AutoValidate &&
                   EqualityComparer<Color>.Default.Equals(BackColor, principal.BackColor) &&
                   FormBorderStyle == principal.FormBorderStyle &&
                   EqualityComparer<IButtonControl>.Default.Equals(CancelButton, principal.CancelButton) &&
                   EqualityComparer<Size>.Default.Equals(ClientSize, principal.ClientSize) &&
                   ControlBox == principal.ControlBox &&
                   EqualityComparer<CreateParams>.Default.Equals(CreateParams, principal.CreateParams) &&
                   DefaultImeMode == principal.DefaultImeMode &&
                   EqualityComparer<Size>.Default.Equals(DefaultSize, principal.DefaultSize) &&
                   EqualityComparer<Rectangle>.Default.Equals(DesktopBounds, principal.DesktopBounds) &&
                   EqualityComparer<Point>.Default.Equals(DesktopLocation, principal.DesktopLocation) &&
                   DialogResult == principal.DialogResult &&
                   HelpButton == principal.HelpButton &&
                   EqualityComparer<Icon>.Default.Equals(Icon, principal.Icon) &&
                   IsMdiChild == principal.IsMdiChild &&
                   IsMdiContainer == principal.IsMdiContainer &&
                   IsRestrictedWindow == principal.IsRestrictedWindow &&
                   KeyPreview == principal.KeyPreview &&
                   EqualityComparer<Point>.Default.Equals(Location, principal.Location) &&
                   EqualityComparer<Rectangle>.Default.Equals(MaximizedBounds, principal.MaximizedBounds) &&
                   EqualityComparer<Size>.Default.Equals(MaximumSize, principal.MaximumSize) &&
                   EqualityComparer<MenuStrip>.Default.Equals(MainMenuStrip, principal.MainMenuStrip) &&
                   EqualityComparer<Padding>.Default.Equals(Margin, principal.Margin) &&
                   EqualityComparer<MainMenu>.Default.Equals(Menu, principal.Menu) &&
                   EqualityComparer<Size>.Default.Equals(MinimumSize, principal.MinimumSize) &&
                   MaximizeBox == principal.MaximizeBox &&
                   EqualityComparer<Form[]>.Default.Equals(MdiChildren, principal.MdiChildren) &&
                   EqualityComparer<Form>.Default.Equals(MdiParent, principal.MdiParent) &&
                   EqualityComparer<MainMenu>.Default.Equals(MergedMenu, principal.MergedMenu) &&
                   MinimizeBox == principal.MinimizeBox &&
                   Modal == principal.Modal &&
                   Opacity == principal.Opacity &&
                   EqualityComparer<Form[]>.Default.Equals(OwnedForms, principal.OwnedForms) &&
                   EqualityComparer<Form>.Default.Equals(Owner, principal.Owner) &&
                   EqualityComparer<Rectangle>.Default.Equals(RestoreBounds, principal.RestoreBounds) &&
                   RightToLeftLayout == principal.RightToLeftLayout &&
                   ShowInTaskbar == principal.ShowInTaskbar &&
                   ShowIcon == principal.ShowIcon &&
                   ShowWithoutActivation == principal.ShowWithoutActivation &&
                   EqualityComparer<Size>.Default.Equals(Size, principal.Size) &&
                   SizeGripStyle == principal.SizeGripStyle &&
                   StartPosition == principal.StartPosition &&
                   TabIndex == principal.TabIndex &&
                   TabStop == principal.TabStop &&
                   Text == principal.Text &&
                   TopLevel == principal.TopLevel &&
                   TopMost == principal.TopMost &&
                   EqualityComparer<Color>.Default.Equals(TransparencyKey, principal.TransparencyKey) &&
                   WindowState == principal.WindowState &&
                   EqualityComparer<IContainer>.Default.Equals(components, principal.components) &&
                   EqualityComparer<ToolStrip>.Default.Equals(toolStrip1, principal.toolStrip1) &&
                   EqualityComparer<ToolStripButton>.Default.Equals(toolStripButton1, principal.toolStripButton1);
            }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private ToolStripLabel tsbBackup;
        private ToolStripLabel tsbRestore;
        }
}

