namespace IFSPStore.App.Register
{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            mtbName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            mtbId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            mtbDocument = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            mtbAddress = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            mtbNeighborhood = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            mcbCity = new ReaLTaiizor.Controls.MaterialComboBox();
            tabPageRegister.SuspendLayout();
            tabControlRegister.SuspendLayout();
            tabPageList.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(mcbCity);
            tabPageRegister.Controls.Add(mtbNeighborhood);
            tabPageRegister.Controls.Add(mtbAddress);
            tabPageRegister.Controls.Add(mtbDocument);
            tabPageRegister.Controls.Add(mtbId);
            tabPageRegister.Controls.Add(mtbName);
            tabPageRegister.Size = new Size(779, 376);
            tabPageRegister.Controls.SetChildIndex(panel1, 0);
            tabPageRegister.Controls.SetChildIndex(mtbName, 0);
            tabPageRegister.Controls.SetChildIndex(mtbId, 0);
            tabPageRegister.Controls.SetChildIndex(mtbDocument, 0);
            tabPageRegister.Controls.SetChildIndex(mtbAddress, 0);
            tabPageRegister.Controls.SetChildIndex(mtbNeighborhood, 0);
            tabPageRegister.Controls.SetChildIndex(mcbCity, 0);
            // 
            // btnSave
            // 
            btnSave.Location = new Point(499, 13);
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(414, 13);
            // 
            // tabControlRegister
            // 
            tabControlRegister.Size = new Size(787, 411);
            // 
            // imageListRegister
            // 
            imageListRegister.ImageStream = (ImageListStreamer)resources.GetObject("imageListRegister.ImageStream");
            imageListRegister.Images.SetKeyName(0, "form.png");
            imageListRegister.Images.SetKeyName(1, "search.png");
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 318);
            panel1.Size = new Size(773, 55);
            // 
            // mtbName
            // 
            mtbName.AnimateReadOnly = false;
            mtbName.AutoCompleteMode = AutoCompleteMode.None;
            mtbName.AutoCompleteSource = AutoCompleteSource.None;
            mtbName.BackgroundImageLayout = ImageLayout.None;
            mtbName.CharacterCasing = CharacterCasing.Normal;
            mtbName.Depth = 0;
            mtbName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbName.HideSelection = true;
            mtbName.Hint = "Name";
            mtbName.LeadingIcon = null;
            mtbName.Location = new Point(19, 17);
            mtbName.MaxLength = 32767;
            mtbName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbName.Name = "mtbName";
            mtbName.PasswordChar = '\0';
            mtbName.PrefixSuffixText = null;
            mtbName.ReadOnly = false;
            mtbName.RightToLeft = RightToLeft.No;
            mtbName.SelectedText = "";
            mtbName.SelectionLength = 0;
            mtbName.SelectionStart = 0;
            mtbName.ShortcutsEnabled = true;
            mtbName.Size = new Size(619, 48);
            mtbName.TabIndex = 3;
            mtbName.TabStop = false;
            mtbName.TextAlign = HorizontalAlignment.Left;
            mtbName.TrailingIcon = null;
            mtbName.UseSystemPasswordChar = false;
            // 
            // mtbId
            // 
            mtbId.AnimateReadOnly = false;
            mtbId.AutoCompleteMode = AutoCompleteMode.None;
            mtbId.AutoCompleteSource = AutoCompleteSource.None;
            mtbId.BackgroundImageLayout = ImageLayout.None;
            mtbId.CharacterCasing = CharacterCasing.Normal;
            mtbId.Depth = 0;
            mtbId.Enabled = false;
            mtbId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbId.HideSelection = true;
            mtbId.Hint = "Id";
            mtbId.LeadingIcon = null;
            mtbId.Location = new Point(657, 17);
            mtbId.MaxLength = 32767;
            mtbId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbId.Name = "mtbId";
            mtbId.PasswordChar = '\0';
            mtbId.PrefixSuffixText = null;
            mtbId.ReadOnly = true;
            mtbId.RightToLeft = RightToLeft.No;
            mtbId.SelectedText = "";
            mtbId.SelectionLength = 0;
            mtbId.SelectionStart = 0;
            mtbId.ShortcutsEnabled = true;
            mtbId.Size = new Size(106, 48);
            mtbId.TabIndex = 4;
            mtbId.TabStop = false;
            mtbId.TextAlign = HorizontalAlignment.Left;
            mtbId.TrailingIcon = null;
            mtbId.UseSystemPasswordChar = false;
            // 
            // mtbDocument
            // 
            mtbDocument.AnimateReadOnly = false;
            mtbDocument.AutoCompleteMode = AutoCompleteMode.None;
            mtbDocument.AutoCompleteSource = AutoCompleteSource.None;
            mtbDocument.BackgroundImageLayout = ImageLayout.None;
            mtbDocument.CharacterCasing = CharacterCasing.Normal;
            mtbDocument.Depth = 0;
            mtbDocument.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbDocument.HideSelection = true;
            mtbDocument.Hint = "Document";
            mtbDocument.LeadingIcon = null;
            mtbDocument.Location = new Point(19, 84);
            mtbDocument.MaxLength = 32767;
            mtbDocument.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbDocument.Name = "mtbDocument";
            mtbDocument.PasswordChar = '\0';
            mtbDocument.PrefixSuffixText = null;
            mtbDocument.ReadOnly = false;
            mtbDocument.RightToLeft = RightToLeft.No;
            mtbDocument.SelectedText = "";
            mtbDocument.SelectionLength = 0;
            mtbDocument.SelectionStart = 0;
            mtbDocument.ShortcutsEnabled = true;
            mtbDocument.Size = new Size(222, 48);
            mtbDocument.TabIndex = 5;
            mtbDocument.TabStop = false;
            mtbDocument.TextAlign = HorizontalAlignment.Left;
            mtbDocument.TrailingIcon = null;
            mtbDocument.UseSystemPasswordChar = false;
            // 
            // mtbAddress
            // 
            mtbAddress.AnimateReadOnly = false;
            mtbAddress.AutoCompleteMode = AutoCompleteMode.None;
            mtbAddress.AutoCompleteSource = AutoCompleteSource.None;
            mtbAddress.BackgroundImageLayout = ImageLayout.None;
            mtbAddress.CharacterCasing = CharacterCasing.Normal;
            mtbAddress.Depth = 0;
            mtbAddress.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbAddress.HideSelection = true;
            mtbAddress.Hint = "Address";
            mtbAddress.LeadingIcon = null;
            mtbAddress.Location = new Point(19, 150);
            mtbAddress.MaxLength = 32767;
            mtbAddress.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbAddress.Name = "mtbAddress";
            mtbAddress.PasswordChar = '\0';
            mtbAddress.PrefixSuffixText = null;
            mtbAddress.ReadOnly = false;
            mtbAddress.RightToLeft = RightToLeft.No;
            mtbAddress.SelectedText = "";
            mtbAddress.SelectionLength = 0;
            mtbAddress.SelectionStart = 0;
            mtbAddress.ShortcutsEnabled = true;
            mtbAddress.Size = new Size(619, 48);
            mtbAddress.TabIndex = 6;
            mtbAddress.TabStop = false;
            mtbAddress.TextAlign = HorizontalAlignment.Left;
            mtbAddress.TrailingIcon = null;
            mtbAddress.UseSystemPasswordChar = false;
            // 
            // mtbNeighborhood
            // 
            mtbNeighborhood.AnimateReadOnly = false;
            mtbNeighborhood.AutoCompleteMode = AutoCompleteMode.None;
            mtbNeighborhood.AutoCompleteSource = AutoCompleteSource.None;
            mtbNeighborhood.BackgroundImageLayout = ImageLayout.None;
            mtbNeighborhood.CharacterCasing = CharacterCasing.Normal;
            mtbNeighborhood.Depth = 0;
            mtbNeighborhood.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbNeighborhood.HideSelection = true;
            mtbNeighborhood.Hint = "Neighborhood";
            mtbNeighborhood.LeadingIcon = null;
            mtbNeighborhood.Location = new Point(19, 218);
            mtbNeighborhood.MaxLength = 32767;
            mtbNeighborhood.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbNeighborhood.Name = "mtbNeighborhood";
            mtbNeighborhood.PasswordChar = '\0';
            mtbNeighborhood.PrefixSuffixText = null;
            mtbNeighborhood.ReadOnly = false;
            mtbNeighborhood.RightToLeft = RightToLeft.No;
            mtbNeighborhood.SelectedText = "";
            mtbNeighborhood.SelectionLength = 0;
            mtbNeighborhood.SelectionStart = 0;
            mtbNeighborhood.ShortcutsEnabled = true;
            mtbNeighborhood.Size = new Size(619, 48);
            mtbNeighborhood.TabIndex = 7;
            mtbNeighborhood.TabStop = false;
            mtbNeighborhood.TextAlign = HorizontalAlignment.Left;
            mtbNeighborhood.TrailingIcon = null;
            mtbNeighborhood.UseSystemPasswordChar = false;
            // 
            // mcbCity
            // 
            mcbCity.AutoResize = false;
            mcbCity.BackColor = Color.FromArgb(255, 255, 255);
            mcbCity.Depth = 0;
            mcbCity.DrawMode = DrawMode.OwnerDrawVariable;
            mcbCity.DropDownHeight = 174;
            mcbCity.DropDownStyle = ComboBoxStyle.DropDownList;
            mcbCity.DropDownWidth = 121;
            mcbCity.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            mcbCity.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcbCity.FormattingEnabled = true;
            mcbCity.IntegralHeight = false;
            mcbCity.ItemHeight = 43;
            mcbCity.Location = new Point(265, 83);
            mcbCity.MaxDropDownItems = 4;
            mcbCity.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mcbCity.Name = "mcbCity";
            mcbCity.Size = new Size(373, 49);
            mcbCity.StartIndex = 0;
            mcbCity.TabIndex = 9;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 478);
            Location = new Point(0, 0);
            Name = "CustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerForm";
            tabPageRegister.ResumeLayout(false);
            tabControlRegister.ResumeLayout(false);
            tabPageList.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit mtbName;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit mtbAddress;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit mtbDocument;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit mtbId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit mtbNeighborhood;
        private ReaLTaiizor.Controls.MaterialComboBox mcbCity;
    }
}