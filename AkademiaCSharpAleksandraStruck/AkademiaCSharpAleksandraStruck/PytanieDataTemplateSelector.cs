using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

using AkademiaCSharpAleksandraStruck;

namespace AkademiaCSharpAleksandraStruck
{


    public class PytanieDataTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            FrameworkElement element = container as FrameworkElement;

            if (element != null && item != null && item is IPytanie)
            {
                if (item is PytanieJednokrotnegoWyboru)
                    return element.FindResource("ListaPytanJednokrotnychTemplate") as DataTemplate;
                else
                    return element.FindResource("ListaPytanWielokrotnychTemplate") as DataTemplate;
            }

            return null;
        }
    }
}
