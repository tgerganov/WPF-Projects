using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace MediaCollection
{
    public class Multimedia : INotifyPropertyChanged
    {
        public enum MediaType
        {
            CD,
            DVD
        };

        private string _title;
        private string _artist;
        private string _genre;
        private string _year;
        private MediaType _type;
        private string _artworkPath;

        public Multimedia()
        {
            _title =
                _artist =
                _genre =
                _year =
                _artworkPath = null;
            _type = MediaType.CD; 
        }

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged("Title");
            }
        }

        public string Artist
        {
            get { return _artist; }
            set
            {
                _artist = value;
                OnPropertyChanged("Artist");
            }
        }

        public string Genre
        {
            get { return _genre; }
            set
            {
                _genre = value;
                OnPropertyChanged("Genre");
            }
        }

        public string Year
        {
            get { return _year; }
            set
            {
                _year = value;
                OnPropertyChanged("Year");
            }
        }

        public MediaType Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged("Type");
            }
        }

        public string ArtworkPath
        {
            get { return _artworkPath; }
            set
            {
                _artworkPath = value;
                OnPropertyChanged("ArtworkPath");
            }
        }

        public override string ToString()
        {
            string s = Title;
            return s;
        }

        protected void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChangedEventArgs args = new PropertyChangedEventArgs(propertyName);
                this.PropertyChanged(this, args);
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
