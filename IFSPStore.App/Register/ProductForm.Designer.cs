namespace IFSPStore.App.Register
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            mtbName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            mtbId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            mcbSaleUnity = new ReaLTaiizor.Controls.MaterialComboBox();
            mcbGroup = new ReaLTaiizor.Controls.MaterialComboBox();
            mtbPurchaseDate = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            mtbQuantity = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            mtbValue = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tabPageRegister.SuspendLayout();
            tabControlRegister.SuspendLayout();
            tabPageList.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(mtbValue);
            tabPageRegister.Controls.Add(mtbQuantity);
            tabPageRegister.Controls.Add(mtbPurchaseDate);
            tabPageRegister.Controls.Add(mcbGroup);
            tabPageRegister.Controls.Add(mcbSaleUnity);
            tabPageRegister.Controls.Add(mtbId);
            tabPageRegister.Controls.Add(mtbName);
            tabPageRegister.Size = new Size(783, 385);
            tabPageRegister.Controls.SetChildIndex(panel1, 0);
            tabPageRegister.Controls.SetChildIndex(mtbName, 0);
            tabPageRegister.Controls.SetChildIndex(mtbId, 0);
            tabPageRegister.Controls.SetChildIndex(mcbSaleUnity, 0);
            tabPageRegister.Controls.SetChildIndex(mcbGroup, 0);
            tabPageRegister.Controls.SetChildIndex(mtbPurchaseDate, 0);
            tabPageRegister.Controls.SetChildIndex(mtbQuantity, 0);
            tabPageRegister.Controls.SetChildIndex(mtbValue, 0);
            // 
            // btnSave
            // 
            btnSave.Location = new Point(693, 13);
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(608, 13);
            // 
            // tabControlRegister
            // 
            tabControlRegister.Size = new Size(791, 420);
            // 
            // imageListRegister
            // 
            imageListRegister.ImageStream = (ImageListStreamer)resources.GetObject("imageListRegister.ImageStream");
            imageListRegister.Images.SetKeyName(0, "form.png");
            imageListRegister.Images.SetKeyName(1, "search.png");
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 327);
            panel1.Size = new Size(777, 55);
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
            mtbName.Location = new Point(18, 20);
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
            mtbName.Size = new Size(584, 48);
            mtbName.TabIndex = 4;
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
            mtbId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbId.HideSelection = true;
            mtbId.Hint = "Id";
            mtbId.LeadingIcon = null;
            mtbId.Location = new Point(621, 20);
            mtbId.MaxLength = 32767;
            mtbId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbId.Name = "mtbId";
            mtbId.PasswordChar = '\0';
            mtbId.PrefixSuffixText = null;
            mtbId.ReadOnly = false;
            mtbId.RightToLeft = RightToLeft.No;
            mtbId.SelectedText = "";
            mtbId.SelectionLength = 0;
            mtbId.SelectionStart = 0;
            mtbId.ShortcutsEnabled = true;
            mtbId.Size = new Size(139, 48);
            mtbId.TabIndex = 5;
            mtbId.TabStop = false;
            mtbId.TextAlign = HorizontalAlignment.Left;
            mtbId.TrailingIcon = null;
            mtbId.UseSystemPasswordChar = false;
            // 
            // mcbSaleUnity
            // 
            mcbSaleUnity.AutoResize = false;
            mcbSaleUnity.BackColor = Color.FromArgb(255, 255, 255);
            mcbSaleUnity.Depth = 0;
            mcbSaleUnity.DrawMode = DrawMode.OwnerDrawVariable;
            mcbSaleUnity.DropDownHeight = 174;
            mcbSaleUnity.DropDownStyle = ComboBoxStyle.DropDownList;
            mcbSaleUnity.DropDownWidth = 121;
            mcbSaleUnity.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            mcbSaleUnity.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcbSaleUnity.FormattingEnabled = true;
            mcbSaleUnity.IntegralHeight = false;
            mcbSaleUnity.ItemHeight = 43;
            mcbSaleUnity.Items.AddRange(new object[] { "kg", "un" });
            mcbSaleUnity.Location = new Point(417, 95);
            mcbSaleUnity.MaxDropDownItems = 4;
            mcbSaleUnity.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mcbSaleUnity.Name = "mcbSaleUnity";
            mcbSaleUnity.Size = new Size(93, 49);
            mcbSaleUnity.StartIndex = 0;
            mcbSaleUnity.TabIndex = 10;
            // 
            // mcbGroup
            // 
            mcbGroup.AutoResize = false;
            mcbGroup.BackColor = Color.FromArgb(255, 255, 255);
            mcbGroup.Depth = 0;
            mcbGroup.DrawMode = DrawMode.OwnerDrawVariable;
            mcbGroup.DropDownHeight = 174;
            mcbGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            mcbGroup.DropDownWidth = 121;
            mcbGroup.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            mcbGroup.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcbGroup.FormattingEnabled = true;
            mcbGroup.IntegralHeight = false;
            mcbGroup.ItemHeight = 43;
            mcbGroup.Location = new Point(18, 168);
            mcbGroup.MaxDropDownItems = 4;
            mcbGroup.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mcbGroup.Name = "mcbGroup";
            mcbGroup.Size = new Size(381, 49);
            mcbGroup.StartIndex = 0;
            mcbGroup.TabIndex = 12;
            // 
            // mtbPurchaseDate
            // 
            mtbPurchaseDate.AllowPromptAsInput = true;
            mtbPurchaseDate.AnimateReadOnly = false;
            mtbPurchaseDate.AsciiOnly = false;
            mtbPurchaseDate.BackgroundImageLayout = ImageLayout.None;
            mtbPurchaseDate.BeepOnError = false;
            mtbPurchaseDate.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            mtbPurchaseDate.Depth = 0;
            mtbPurchaseDate.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbPurchaseDate.HidePromptOnLeave = false;
            mtbPurchaseDate.HideSelection = true;
            mtbPurchaseDate.InsertKeyMode = InsertKeyMode.Default;
            mtbPurchaseDate.LeadingIcon = null;
            mtbPurchaseDate.Location = new Point(532, 96);
            mtbPurchaseDate.Mask = "00/00/0000";
            mtbPurchaseDate.MaxLength = 32767;
            mtbPurchaseDate.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbPurchaseDate.Name = "mtbPurchaseDate";
            mtbPurchaseDate.PasswordChar = '\0';
            mtbPurchaseDate.PrefixSuffixText = null;
            mtbPurchaseDate.PromptChar = '_';
            mtbPurchaseDate.ReadOnly = false;
            mtbPurchaseDate.RejectInputOnFirstFailure = false;
            mtbPurchaseDate.ResetOnPrompt = true;
            mtbPurchaseDate.ResetOnSpace = true;
            mtbPurchaseDate.RightToLeft = RightToLeft.No;
            mtbPurchaseDate.SelectedText = "";
            mtbPurchaseDate.SelectionLength = 0;
            mtbPurchaseDate.SelectionStart = 0;
            mtbPurchaseDate.ShortcutsEnabled = true;
            mtbPurchaseDate.Size = new Size(228, 48);
            mtbPurchaseDate.SkipLiterals = true;
            mtbPurchaseDate.TabIndex = 13;
            mtbPurchaseDate.TabStop = false;
            mtbPurchaseDate.Text = "  /  /";
            mtbPurchaseDate.TextAlign = HorizontalAlignment.Left;
            mtbPurchaseDate.TextMaskFormat = MaskFormat.IncludeLiterals;
            mtbPurchaseDate.TrailingIcon = null;
            mtbPurchaseDate.UseSystemPasswordChar = false;
            mtbPurchaseDate.ValidatingType = null;
            // 
            // mtbQuantity
            // 
            mtbQuantity.AllowPromptAsInput = true;
            mtbQuantity.AnimateReadOnly = false;
            mtbQuantity.AsciiOnly = false;
            mtbQuantity.BackgroundImageLayout = ImageLayout.None;
            mtbQuantity.BeepOnError = false;
            mtbQuantity.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            mtbQuantity.Depth = 0;
            mtbQuantity.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbQuantity.HidePromptOnLeave = false;
            mtbQuantity.HideSelection = true;
            mtbQuantity.Hint = "Quantity";
            mtbQuantity.InsertKeyMode = InsertKeyMode.Default;
            mtbQuantity.LeadingIcon = null;
            mtbQuantity.Location = new Point(250, 96);
            mtbQuantity.Mask = "999999";
            mtbQuantity.MaxLength = 32767;
            mtbQuantity.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbQuantity.Name = "mtbQuantity";
            mtbQuantity.PasswordChar = '\0';
            mtbQuantity.PrefixSuffixText = null;
            mtbQuantity.PromptChar = '_';
            mtbQuantity.ReadOnly = false;
            mtbQuantity.RejectInputOnFirstFailure = false;
            mtbQuantity.ResetOnPrompt = true;
            mtbQuantity.ResetOnSpace = true;
            mtbQuantity.RightToLeft = RightToLeft.No;
            mtbQuantity.SelectedText = "";
            mtbQuantity.SelectionLength = 0;
            mtbQuantity.SelectionStart = 0;
            mtbQuantity.ShortcutsEnabled = true;
            mtbQuantity.Size = new Size(149, 48);
            mtbQuantity.SkipLiterals = true;
            mtbQuantity.TabIndex = 14;
            mtbQuantity.TabStop = false;
            mtbQuantity.TextAlign = HorizontalAlignment.Left;
            mtbQuantity.TextMaskFormat = MaskFormat.IncludeLiterals;
            mtbQuantity.TrailingIcon = null;
            mtbQuantity.UseSystemPasswordChar = false;
            mtbQuantity.ValidatingType = null;
            // 
            // mtbValue
            // 
            mtbValue.AllowPromptAsInput = true;
            mtbValue.AnimateReadOnly = false;
            mtbValue.AsciiOnly = false;
            mtbValue.BackgroundImageLayout = ImageLayout.None;
            mtbValue.BeepOnError = false;
            mtbValue.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            mtbValue.Depth = 0;
            mtbValue.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbValue.HidePromptOnLeave = false;
            mtbValue.HideSelection = true;
            mtbValue.Hint = "Value";
            mtbValue.InsertKeyMode = InsertKeyMode.Default;
            mtbValue.LeadingIcon = null;
            mtbValue.Location = new Point(18, 95);
            mtbValue.Mask = "999999,99";
            mtbValue.MaxLength = 32767;
            mtbValue.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbValue.Name = "mtbValue";
            mtbValue.PasswordChar = '\0';
            mtbValue.PrefixSuffixText = null;
            mtbValue.PromptChar = '_';
            mtbValue.ReadOnly = false;
            mtbValue.RejectInputOnFirstFailure = false;
            mtbValue.ResetOnPrompt = true;
            mtbValue.ResetOnSpace = true;
            mtbValue.RightToLeft = RightToLeft.No;
            mtbValue.SelectedText = "";
            mtbValue.SelectionLength = 0;
            mtbValue.SelectionStart = 0;
            mtbValue.ShortcutsEnabled = true;
            mtbValue.Size = new Size(207, 48);
            mtbValue.SkipLiterals = true;
            mtbValue.TabIndex = 15;
            mtbValue.TabStop = false;
            mtbValue.Text = "      ,";
            mtbValue.TextAlign = HorizontalAlignment.Left;
            mtbValue.TextMaskFormat = MaskFormat.IncludeLiterals;
            mtbValue.TrailingIcon = null;
            mtbValue.UseSystemPasswordChar = false;
            mtbValue.ValidatingType = null;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 487);
            Location = new Point(0, 0);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductForm";
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
        private ReaLTaiizor.Controls.MaterialTextBoxEdit mtbId;
        private ReaLTaiizor.Controls.MaterialComboBox mcbSaleUnity;
        private ReaLTaiizor.Controls.MaterialComboBox mcbGroup;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox mtbValue;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox mtbQuantity;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox mtbPurchaseDate;
    }
}