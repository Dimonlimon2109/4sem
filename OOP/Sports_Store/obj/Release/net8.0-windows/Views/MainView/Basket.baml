   M S B A M L   `   `   `  ���� G  CSports_Store, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Sports_store.Views.MainViewSports_store.Views.MainView  A%clr-namespace:Sports_store.ViewModelsSports_store.ViewModels  (    "Sports_store.Views.MainView.Basket   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XRoyWpf.Behaviors.MessengerTrigger, Version=0.1.2.0, Culture=neutral, PublicKeyToken=nullJ FRoyWpf.Packages, Version=0.1.3.0, Culture=neutral, PublicKeyToken=nullK GRoyWpf.Utilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L 9http://schemas.microsoft.com/winfx/2006/xaml/presentation        R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ;local)clr-namespace:Sports_store.Views.MainView     <
viewmodels%clr-namespace:Sports_store.ViewModels     _	 [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3aW
 SSystem.Windows.Interactivity, Version=0.1.2.0, Culture=neutral, PublicKeyToken=null5i+http://schemas.microsoft.com/xaml/behaviors 	 
 
�������  � DataContext  &    Sports_store.ViewModels.BasketVM  .���  � RowDefinitions �� $��5* ��� �� $��60 �.+��� $
��Auto=�.���� $��0��$	��Top=�$��30q����� *BasketGoods+���� .R�A�  A� Columns$ 1������ .R���  �� Orientation$ 
Horizontal=�$��0 0 0 30q�.+��� $	��250��$	��250��$
��Fill=����� *
Good.Image+�� $��	20 40 0 0q�$��20(�$
��Wrap=�$	��250��$��80��   TextBlockAuth#��[  ���� *	Good.Name+�� #��[  ���� *	Good.Cost+�� #��[  $��30(�$��0 0 0 25q�$��-��* 	 $Microsoft.Xaml.Behaviors.Interaction   Triggers + 	 %Microsoft.Xaml.Behaviors.EventTrigger     	EventName$ 	MouseDown��* 	 $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 2 	 ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command �� *DataContext.Minus+ �� RelativeSource �� 	 �� AncestorType"	 >�
   CommandParameter
 �� �� #��[  $��	10 0 10 0q����� *Amount+ �� UpdateSourceTrigger$ PropertyChanged=��� #��[  $��30(�$��	0 0 30 25q�$��+��   $ 	MouseDown��.    �� *DataContext.Plus+ �� "	 >�
 �� �� #��[  $��Всего:���� #��[  ���� *	TotalCost+$ PropertyChanged=��� #��[  $��	-15 0 0 0q�$��руб.����   BlackWhiteButton#���  $��60��$��Удалить��$��10 0 0 0q����� *DataContext.DeleteFromBasket+ �� "	 >����� �� $��1��$ 
Horizontal=�.+��� $��20 10 10 10q�.+��� #��[  $��
Адрес����   TextBoxAuth#��[ ���� *CurrentOrder.Adress+�� $��
0 10 10 10q�.+��� #��[  $9��3Способ оплаты при получении���� $ 
Horizontal=�.+�	� $��Наличные�� d� 	IsChecked �� *Cash+ �� Mode$ TwoWay=�	� $%��Банковская карта�� �� *Card+$ TwoWay=��� $��
0 10 10 10q�.+��� #��[  $,��&Комментарий к заказу���� #��[ ���� *CurrentOrder.Description+�� $��
0 10 10 10q�.+��� #��[  $��
Итого���� #��[  ���� *CurrentOrder.TotalCost+�� $��2��#��[ $��Заказать��$��50��$	��100������ *OrderingGoods+