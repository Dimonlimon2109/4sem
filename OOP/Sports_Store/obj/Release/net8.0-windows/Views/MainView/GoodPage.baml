   M S B A M L   `   `   `  ���� G  CSports_Store, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Sports_store.Views.MainViewSports_store.Views.MainView  A%clr-namespace:Sports_store.ViewModelsSports_store.ViewModels  *    $Sports_store.Views.MainView.GoodPage   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XRoyWpf.Behaviors.MessengerTrigger, Version=0.1.2.0, Culture=neutral, PublicKeyToken=nullJ FRoyWpf.Packages, Version=0.1.3.0, Culture=neutral, PublicKeyToken=nullK GRoyWpf.Utilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L 9http://schemas.microsoft.com/winfx/2006/xaml/presentation        R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ;local)clr-namespace:Sports_store.Views.MainView     <
viewmodels%clr-namespace:Sports_store.ViewModels     _	 [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes 	 _
 [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3aW SSystem.Windows.Interactivity, Version=0.1.2.0, Culture=neutral, PublicKeyToken=null5i+http://schemas.microsoft.com/xaml/behaviors 
  
�������  � DataContext  (   "Sports_store.ViewModels.GoodPageVM   � 	Resources     BooleanToVisibilityConverter��%   &	        �� .���  � ColumnDefinitions �� $��3* ��� $
��1.5* ��� $	��220 � � RowDefinitions �� $
��2.5* ��� �� .+��� $��0��$��0�� �� BitmapScalingMode$ HighQuality=�$
��Auto��$
��Auto��$��
20 20 20 0q����� *CurrentGood.Image+ �� FallbackValue$5 /pack://application:,,,/Resources/foto-empty.png�� �� TargetNullValue$5 /pack://application:,,,/Resources/foto-empty.png��* 
 $Microsoft.Xaml.Behaviors.Interaction   Triggers + 
 %Microsoft.Xaml.Behaviors.EventTrigger     	EventName$ 	MouseDown��* 
 $Microsoft.Xaml.Behaviors.TriggerBase	   Actions.	 2 
 ,Microsoft.Xaml.Behaviors.InvokeCommandAction  
   Command
 �� *ChangeImage+�� $��1��$��0��$��2��$��	0 40 30 0q�.+���  �� Orientation$ 
Horizontal=�.+���   TextBoxGood#���  $��23(� �� TextWrapping$
 Wrap=� �� 	MaxLength$ 50��$��
Montserrat)����� *CurrentGood.Name+��   ComboBoxCollapsed#���   �� Text �� *CurrentGood.Category+���� *
Categories+��   TextBlockCollapsed#���  ���� *CurrentGood.Category+�� #��[  �� *CurrentGood.Type+���� *Types+�� #���  ���� *CurrentGood.Type+�� #��[  �� *CurrentGood.Color+���� *Colors+�� #���  ���� *CurrentGood.Color+�� $ 
Horizontal=�.+��� #���  $
��Auto��$��0 0 5 0q����� *CurrentGood.Cost+�� $��0 5 0 0q�  TextBlockAuth#��[ $��руб���� $��В корзину��$	��100��$
��Left=����� *AddToBasket+����  �� 
TargetType" ��  BlackWhiteButton �� BasedOn# [  �� Triggers ��  �� Binding �� *	IsAdmin+ �� Value True.a���  �� Property � y� �� Value$ 	Collapsed=��� $
��Left=�$��Normal"�$	��Top=�$��1��$��0��$��10 0 0 0q�$��2��$
��Auto��$	��500��$
 Wrap=�  DescriptionGood#���  ���� *CurrentGood.Description+ �� UpdateSourceTrigger$ PropertyChanged=��� $ 
Horizontal=�$��2��$��0������ " ��.���  � y�$ Visible=� ��  �� *	IsAdmin+ True.a���  � y�$ 	Collapsed=�.+��� $��20 0 0 0q�.+�( 	 "MaterialDesignThemes.Wpf.RatingBar  $��25��$��0 25 0 0q�   Value �� *CurrentReview.Rating+ �� Mode$ TwoWay=��� $��40��$��0 30 0 0q�$��Добавить������ *	AddReview+�� $��15(�$
 Wrap=����#E5E5E5$	��300��$��40 0 0 0q�$	��100��$	 256������ *CurrentReview.Description+$ PropertyChanged=��� $��	20 20 0 0q�$��2��$��0��$��2��$ 
Horizontal=����� " ��.���  � y�$ 	Collapsed=� ��  �� *	IsAdmin+ True.a���  � y�$ Visible=�.+��� .+��� $ 
Horizontal=�.+��� #��[ $��Количество:���� #��[ $	��100������ *CurrentGood.StockQuantity+$ PropertyChanged=�$ TwoWay=��� $ 
Horizontal=�.+��� #��[ $ ��Всего продано:���� #��[ ���� *CurrentGood.SaledAmount+�� $ 
Horizontal=�.+��� #��[ $ ��Всего отзывов:���� #��[ ���� *ReviewsNumber+�� $ 
Horizontal=����� " �� ��  �� *	IsAdmin+	 false.a���  � y�$ 	Collapsed=�.+��� $0��*pack://application:,,,/Resources/trash.png��$��64��$��64������ " ��.���  � y�$ Visible=� ��  �� *
IsUpdate+$ PropertyChanged=� True.a���  � y�$ 	Collapsed=�   $ 	MouseDown��.	   
 �� *
DeleteGood+�� $/��)pack://application:,,,/Resources/edit.png��$��64��$��64������ " ��.���  � y�$ Visible=� ��  �� *
IsUpdate+$ PropertyChanged=� True.a���  � y�$ 	Collapsed=�   $ 	MouseDown��.	      CommandParameter$
 True��
 �� *
UpdateGood+�� $/��)pack://application:,,,/Resources/save.png��$��64��$��64������ " ��.���  � y�$ Visible=� ��  �� *
IsUpdate+$ PropertyChanged=�	 False.a���  � y�$ 	Collapsed=�   $ 	MouseDown��.	   $ False��
 �� *
UpdateGood+�� $��1��$��1��$��2��$��2��$��20 0 0 0q����� " �� ��  �� *
IsUpdate+ true.a���  � y�$ 	Collapsed=�.+��� #��[ $��Отзывы��$��Center=��� $��0q�$	��250��$��Visible=�$��Stretch=�$��Stretch=����� *	Reviews+   AppleStyleScrollBarStyle��%G   '��       7  �� " ��.���  � ��8   ��  � ��$ Hidden=����� " ��.���  �@�Tag �� *DataContext.IsAdmin+ �� RelativeSource ��  �� AncestorType" ����  � �� ��  �� 
TargetType" ��.R��� $��_Border�� �� Padding$ 2q� J� SnapsToDevicePixels$
 true��._���  �� Triggers ^�   ^� 
Conditions  �� ! �� Binding! �� *Tag+ �� *Self+" �� Value" True�� ! �� # �� Path$# 
IsSelected� �� *Self+" True.0��� $ �� 
TargetName$$ _Border�� � ��
 �  ��^�   �� ! �� *Tag+ �� *Self+	" False�� ! �� $# 
IsSelected� �� *Self+" True.0��� $$ _Border�� � ��
 ���� ���� .R�A� % A� Columns$% 1������ .R��� 
���   �$��1q�$��5q�$ 5q�._��� .+��� $ 
Horizontal=�.+�A� $��70��$��70��$	��Top=����� & �� ImageSource& �� *
User.Image+$ PropertyChanged=��� $��10 0 0 0q�.+��� $��
Montressat)�$��16(����� *	User.Name+�� $
��Bold"�$��13(����� *Date+�� $ 
Horizontal=�.+��� $
��Bold"�$��0 0 5 0q�$��13(����� *Rating+�� $��out of 5��$��13(���   
ReviewText#���  ���� *Description+