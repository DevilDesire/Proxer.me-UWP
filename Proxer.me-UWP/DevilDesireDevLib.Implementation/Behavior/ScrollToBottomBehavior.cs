using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Microsoft.Xaml.Interactivity;
using DevilDesireDevLib.Implementation.Extensions;

namespace DevilDesireDevLib.Implementation.Behavior
{
    public class ScrollToBottomBehavior : DependencyObject, IBehavior
    {
        public DependencyObject AssociatedObject { get; private set; }

        public object ItemsSource
        {
            get { return GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        public static readonly DependencyProperty ItemsSourceProperty = DependencyProperty.Register("ItemsSource", typeof(object), typeof(ScrollToBottomBehavior), new PropertyMetadata(null, ItemsSourcePropertyChanged));

        private static void ItemsSourcePropertyChanged(object sender,
        DependencyPropertyChangedEventArgs e)
        {
            ScrollToBottomBehavior behavior = sender as ScrollToBottomBehavior;
            if (behavior?.AssociatedObject == null || e.NewValue == null) return;
            //ScrollViewer scrollViewer = behavior.AssociatedObject.GetFirstDescendantOfType<ScrollViewer>();
            //scrollViewer.ChangeView(0.0f, double.MaxValue, 1.0f);

            INotifyCollectionChanged collection = behavior.ItemsSource as INotifyCollectionChanged;
            if (collection != null)
            {
                //scrollViewer.SizeChanged += ScrollViewer_SizeChanged;
                //collection.CollectionChanged += (s, args) =>
                //{
                    ScrollViewer scrollViewer = behavior.AssociatedObject as ScrollViewer;
                    ItemsControl itemsControl = behavior.AssociatedObject.GetFirstDescendantOfType<ItemsControl>();        //.GetFirstDescendantOfType<ScrollViewer>();
                    scrollViewer?.ChangeView(0.0f, itemsControl.ActualHeight, 1.0f);
                //};
            }
        }

        private static void ScrollViewer_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ((ScrollViewer)sender).ChangeView(0.0f, double.MaxValue, 1.0f);
            
        }

        public void Attach(DependencyObject associatedObject)
        {
            ScrollViewer control = associatedObject as ScrollViewer;
            if (control == null)
            {
                throw new ArgumentException("ScrollToBottomBehavior can be attached only to ListView.");
            }

            AssociatedObject = associatedObject;
        }

        public void Detach()
        {
            AssociatedObject = null;
        }
    }
}