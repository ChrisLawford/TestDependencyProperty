using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDependencyProperty
{
    class MainWindowViewModel:ObservableObject
    {

        private double m_height;

        public double Height { get { return m_height; } set {m_height = value; OnPropertyChanged("Height"); } }

        private double m_width;

        public double Width { get { return m_width; } set { m_width = value; OnPropertyChanged("Width"); } }

        private double m_textblockheight;

        public double TextBlockHeight { get { return m_textblockheight; } set { m_textblockheight = value; OnPropertyChanged("TextBlockHeight"); } }

        private double m_textblockwidth;

        public double TextBlockWidth { get { return m_textblockwidth; } set { m_textblockwidth = value; OnPropertyChanged("TextBlockWidth"); } }
    }
}
