using System;
using System.Collections.Generic;
using System.Text;

namespace NotePad___
{
    class Note
    {
        private string myTitle;

        private string myText;

        public string MyTitle 
        {
            get 
            {
                return myTitle;
            }

            set 
            {
                myTitle = value;
            }
        }
        
        public string MyText 
        {
            get 
            {
                return myText;
            }

            set 
            {
                myText = value;
            }
        }

        public Note(string title, string text) 
        {
            myTitle = title;
            myText = text;
        }

    }
}
