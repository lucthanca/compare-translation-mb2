using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Vadu.Controls.TextBoxes
{
    public class LTextBox : TextBox
    {
        #region Fields

        #region Protected Fields

        protected string _placeholderText = "Input some text here..."; //The placeholder text
        protected Color _placeholderColor; //Color of the placeholder when the control does not have focus
        protected Color _placeholderActiveColor; //Color of the placeholder when the control has focus

        #endregion

        #region Private Fields

        private Panel placeholderContainer; //Container to hold the placeholder
        private Font placeholderFont; //Font of the placeholder
        private SolidBrush placeholderBrush; //Brush for the placeholder

        #endregion

        #endregion

        #region Constructors

        public LTextBox()
        {
            Initialize();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Initializes placeholder properties and adds CtextBox events
        /// </summary>
        private void Initialize()
        {
            //Sets some default values to the placeholder properties
            _placeholderColor = Color.FromArgb(80,80,80);
            _placeholderActiveColor = Color.FromArgb(158,158,158);
            placeholderFont = this.Font;
            placeholderBrush = new SolidBrush(_placeholderActiveColor);
            placeholderContainer = null;

            //Draw the placeholder, so we can see it in design time
            DrawPlaceholder();

            //Eventhandlers which contains function calls. 
            //Either to draw or to remove the placeholder
            this.Enter += new EventHandler(ThisHasFocus);
            this.Leave += new EventHandler(ThisWasLeaved);
            this.TextChanged += new EventHandler(ThisTextChanged);
        }

        /// <summary>
        /// Removes the placeholder if it should
        /// </summary>
        private void RemovePlaceholder()
        {
            if (placeholderContainer != null)
            {
                this.Controls.Remove(placeholderContainer);
                placeholderContainer = null;
            }
        }

        /// <summary>
        /// Draws the placeholder if the text length is 0
        /// </summary>
        private void DrawPlaceholder()
        {
            if (this.placeholderContainer == null && this.TextLength <= 0)
            {
                placeholderContainer = new Panel(); // Creates the new panel instance
                placeholderContainer.Paint += new PaintEventHandler(placeholderContainer_Paint);
                placeholderContainer.Invalidate();
                placeholderContainer.Click += new EventHandler(placeholderContainer_Click);
                this.Controls.Add(placeholderContainer); // adds the control
            }
        }

        #endregion

        #region Eventhandlers

        #region Placeholder Events

        private void placeholderContainer_Click(object sender, EventArgs e)
        {
            this.Focus(); //Makes sure you can click wherever you want on the control to gain focus
        }

        private void placeholderContainer_Paint(object sender, PaintEventArgs e)
        {
            //Setting the placeholder container up
            placeholderContainer.Location = new Point(2, 0); // sets the location
            placeholderContainer.Height = this.Height; // Height should be the same as its parent
            placeholderContainer.Width = this.Width; // same goes for width and the parent
            placeholderContainer.Anchor = AnchorStyles.Left | AnchorStyles.Right; // makes sure that it resizes with the parent control



            if (this.ContainsFocus)
            {
                //if focused use normal color
                placeholderBrush = new SolidBrush(this._placeholderActiveColor);
            }

            else
            {
                //if not focused use not active color
                placeholderBrush = new SolidBrush(this._placeholderColor);
            }

            //Drawing the string into the panel 
            Graphics g = e.Graphics;
            g.DrawString(this._placeholderText, placeholderFont, placeholderBrush, new PointF(-2f, 1f));//Take a look at that point
            //The reason I'm using the panel at all, is because of this feature, that it has no limits
            //I started out with a label but that looked very very bad because of its paddings 

        }

        #endregion

        #region LTextBox Events

        private void ThisHasFocus(object sender, EventArgs e)
        {
            //if focused use focus color
            placeholderBrush = new SolidBrush(this._placeholderActiveColor);

            //The placeholder should not be drawn if the user has already written some text
            if (this.TextLength <= 0)
            {
                RemovePlaceholder();
                DrawPlaceholder();
            }
        }

        private void ThisWasLeaved(object sender, EventArgs e)
        {
            //if the user has written something and left the control
            if (this.TextLength > 0)
            {
                //Remove the placeholder
                RemovePlaceholder();
            }
            else
            {
                //But if the user didn't write anything, Then redraw the control.
                this.Invalidate();
            }
        }

        private void ThisTextChanged(object sender, EventArgs e)
        {
            //If the text of the textbox is not empty
            if (this.TextLength > 0)
            {
                //Remove the placeholder
                RemovePlaceholder();
            }
            else
            {
                //But if the text is empty, draw the placeholder again.
                DrawPlaceholder();
            }
        }

        #region Overrided Events

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //Draw the placeholder even in design time
            DrawPlaceholder();
        }

        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            base.OnInvalidated(e);
            //Check if there is a placeholder
            if (placeholderContainer != null)
                //if there is a placeholder it should also be invalidated();
                placeholderContainer.Invalidate();
        }

        #endregion

        #endregion

        #endregion

        #region Properties
        [Category("Placeholder attribtues")]
        [Description("Sets the text of the placeholder")]
        public string Placeholder
        {
            get { return this._placeholderText; }
            set
            {
                this._placeholderText = value;
                this.Invalidate();
            }
        }

        [Category("Placeholder attribtues")]
        [Description("When the control gaines focus, this color will be used as the placeholder's forecolor")]
        public Color PlaceholderActiveForeColor
        {
            get { return this._placeholderActiveColor; }

            set
            {
                this._placeholderActiveColor = value;
                this.Invalidate();
            }
        }

        [Category("Placeholder attribtues")]
        [Description("When the control looses focus, this color will be used as the placeholder's forecolor")]
        public Color PlaceholderForeColor
        {
            get { return this._placeholderColor; }

            set
            {
                this._placeholderColor = value;
                this.Invalidate();
            }
        }

        [Category("Placeholder attribtues")]
        [Description("The font used on the placeholer text. Default is the same as the control")]
        public Font PlaceholderFont
        {
            get
            {
                return this.placeholderFont;
            }

            set
            {
                this.placeholderFont = value;
                this.Invalidate();
            }
        }

        #endregion
    }
}
