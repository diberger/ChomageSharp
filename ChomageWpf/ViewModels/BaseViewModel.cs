using System.ComponentModel;

namespace ChomageWpf.ViewModels
{
    public class BaseViewModel
    {
        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        protected BaseViewModel()
        {
        }

        #endregion

        #region Membres de INotifyPropertyChanged

        /// <summary>
        /// Se déclenche lorsqu'une propriété de cet objet a une nouvelle valeur
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Déclenche l'évènement sur  l'évènement PropertyChanged
        /// </summary>
        /// <param name="propertyName">La propriété qui a une nouvelle valeur</param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }

        #endregion
    }
}