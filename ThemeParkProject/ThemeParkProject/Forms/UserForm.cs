using ThemeParkProject.Model;
using ThemeParkProject.Algorithms;
using System;
using System.Windows.Forms;

namespace ThemeParkProject.Forms{
    public partial class UserForm : Form
        //a new queue with initialized
        private GuestQueue guestqueue;
        //initialize textbox and text
        private TextBox nameTextBox;
        private TextBox fundTextBox;

        //initialize a listbox
        private ListBox listBoxControl;

        //initialize a label for richest guest
        private Label richestGuestLabel;

        public UserForm() {
            InitializeComponent();
            InitializeCustomControls();
            guestqueue = new GuestQueue(20);
        }

        private void InitializeCustomControls(){
            nameTextBox = new TextBox();
            nameTextBox.Location = new System.Drawing.Point(110, 55); 
            nameTextBox.Size = new System.Drawing.Size(210, 30);       
            nameTextBox.Name = "nameTextName";
            this.Controls.Add(nameTextName);

            fundTextBox = new TextBox();
            fundTextBox.Location = new System.Drawing.Point(110, 55); 
            fundTextBox.Size = new System.Drawing.Size(210, 30);       
            fundTextBox = "fundTextBox";
            this.Controls.Add(fundTextBox);

            listBoxControl = new ListBox();
            listBoxControl.Location = new System.Drawing.Point(60, 50); 
            listBoxControl.Size = new System.Drawing.Size(220, 330); 
            listBoxControl.Name = "listBoxControl";
            this.Controls.Add(listBoxControl);


            richestGuestLabel = new Label();
            richestGuestLabel.Location = new System.Drawing.Point(60, 360); // Example position
            richestGuestLabel.Size = new System.Drawing.Size(360, 30);      // Example size
            richestGuestLabel.Name = "richestGuestLabel";
            richestGuestLabel.Text = "Guest with most fund: --";

    // Add the label to the form's controls
    this.Controls.Add(lblRichestGuest);
        }

        // //form Constructor
        // public UserForm(){
        //     //create a queue with a capacity of 20 guests
        //     InitializeComponent();
        //     guestqueue = new GuestQueue(20);
        // }

        private void updateQueueUI(){
            listBoxControl.Items.Clear();
            //add each guest object to listBoxControl
            foreach(var guest in guestqueue.peekAll()){
                listBoxControl.Items.Add(guest.ToString())
            }
        }

        public void enqueueGuestBtn(object sender, EventArgs e){
            string guestname = nameTextBox.Text;
            if(decimal.TryParse(fundTextBox.Text, out decimal guestfund)){
                Guest guest = new Guest(guestname, guestfund){
                    if(guestqueue.Enqueue(guest)){
                        updateQueueUI();
                    }else{
                        MessageBox.show("Queue is filled up")
                    }
                }
            }else{
                MessageBox.Show("Insufficient fund")
            }
        }

        public void dequeueGuestBtn(object sender, EventArgs e){
            if(guestqueue.Dequeue()){
                 updateQueueUI();
                 else{
                    MessageBox.show("Queue already empty, cant be dequeued")
                 }
            }
        }

        private void FindhMostFundBtn(object sender, EventArgs e){
            dequeueGuestBtn guestWitMostFind = guestqueue.FindhMostFund();
            if(guestWitMostFind != null){
                richestGuestLabel.Text = $"{guestWitMostFind.ToString()} has (${guestWitMostFind.GuestFund})"
            }MessageBox.show("Queue is empty!")
        }
    
}
