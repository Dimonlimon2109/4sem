   M S B A M L   `   `   `  ����G  CSports_Store, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Sports_store.Views.MainViewSports_store.Views.MainView  5      A%clr-namespace:Sports_store.ViewModelsSports_store.ViewModels  5      *    $Sports_store.Views.MainView.GoodPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XRoyWpf.Behaviors.MessengerTrigger, Version=0.1.2.0, Culture=neutral, PublicKeyToken=nullJ FRoyWpf.Packages, Version=0.1.3.0, Culture=neutral, PublicKeyToken=nullK GRoyWpf.Utilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L 9http://schemas.microsoft.com/winfx/2006/xaml/presentation        5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:Sports_store.Views.MainView     5      <
viewmodels%clr-namespace:Sports_store.ViewModels     5      _	 [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes 	 5	      _
 [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3aW SSystem.Windows.Interactivity, Version=0.1.2.0, Culture=neutral, PublicKeyToken=null5i+http://schemas.microsoft.com/xaml/behaviors 
  6[   
�������  � DataContext  5      (   "Sports_store.ViewModels.GoodPageVM  5   
    � 	Resources 5          BooleanToVisibilityConverter��%   &	        �� 5   
   6'   5      .��5   
   �  � ColumnDefinitions 5      �� 5      $��3* �6#   �� 5      $
��1.5* �6#   �� 5      $	��220 �6#    � RowDefinitions 5      �� 5      $
��2.5* �6    �� 5      �� 5      .+�5      �� $��0��6   $��0��6$    �� BitmapScalingMode$ HighQuality=�6�   $
��Auto��6  $
��Auto��6  $��
20 20 20 0q�6$  ��61   �� *CurrentGood.Image+ �� FallbackValue$5 /pack://application:,,,/Resources/foto-empty.png�� �� TargetNullValue$5 /pack://application:,,,/Resources/foto-empty.png��* 
 $Microsoft.Xaml.Behaviors.Interaction   Triggers 5      + 
 %Microsoft.Xaml.Behaviors.EventTrigger  5         	EventName$ 	MouseDown��6%   * 
 $Microsoft.Xaml.Behaviors.TriggerBase	   Actions.	 5      2 
 ,Microsoft.Xaml.Behaviors.InvokeCommandAction  
   Command
 60   �� *ChangeImage+5       5"      �� 5#   
   $��1��6   $��0��6%   $��2��62   $��	0 40 30 0q�6F   .+�5$      ��  �� Orientation$ 
Horizontal=�6   .+�5%      ��   TextBoxGood#���  6   $��23(�6@    �� TextWrapping$
 Wrap=�6N    �� 	MaxLength$ 50��6b   $��
Montserrat)�6q   ��6�   �� *CurrentGood.Name+5&      �� 5'        ComboBoxCollapsed#���  6    �� Text 6C   �� *CurrentGood.Category+��6i   �� *
Categories+5(      �� 5)        TextBlockCollapsed#���  6   ��6E   �� *CurrentGood.Category+�� 5*      #��[ 6    6B   �� *CurrentGood.Type+��6d   �� *Types+�� 5+      #���  6   ��6E   �� *CurrentGood.Type+�� 5,      #��[ 6    6B   �� *CurrentGood.Color+��6e   �� *Colors+�� 5-      #���  6   ��6E   �� *CurrentGood.Color+�� 5.      $ 
Horizontal=�6   .+�5/      �� #���  6   $
��Auto��6@   $��0 0 5 0q�6M   ��6^   �� *CurrentGood.Cost+ �� UpdateSourceTrigger$ PropertyChanged=��� 50      $��0 5 0 0q�6     TextBlockAuth#��[ 6-   $��руб��6T   51      �� 52      $��В корзину��6   $	��100��6I   $
��Left=�6U   ��6)   �� *AddToBasket+��53      �� 54       �� 
TargetType" ��6     BlackWhiteButton �� BasedOn# [ 60    �� Triggers 55      �� 56       �� Binding 6*   �� *	IsAdmin+ �� Value True6F   .a�57   "   ��  �� Property � y� �� Value$ 	Collapsed=�6?   58      5:      5<      5=      �� 5>   
   $
��Left=�6   $��Normal"�6-   $	��Top=�6A   $��1��6Y   $��0��6f   $��	10 20 0 0q�6v   $��2��5?      $
��Auto��6&   $	��450��64   $
 Wrap=�6@     DescriptionGood#���  6T   ��5@      �� *CurrentGood.Description+$ PropertyChanged=��� 5A   
   $ 
Horizontal=�6   $��2��6.   $��0��6;   ��5B      �� 5C      " ��6   .�5D      ��  � y�$ Visible=�63    5E      �� 5F       6&   �� *	IsAdmin+ True6B   .a�5G      ��  � y�$ 	Collapsed=�6;   5H      5J      .+�5L      �� $��20 0 0 0q�6   .+�5M      ( 	 "MaterialDesignThemes.Wpf.RatingBar  $��25��6_   $��0 25 0 0q�6k      Value 6+   �� *CurrentReview.Rating+ �� Mode$ TwoWay=�6k   �� 5N      $��40��6   $��0 30 0 0q�6%   $��Добавить��67   ��6J   �� *	AddReview+5O      �� 5P      $��15(�6   $
 Wrap=�6$   ���#E5E5E5$	��300��6M   $��40 0 0 0q�6Y   $	��100��6k   $	 256��6x   ��6�   �� *CurrentReview.Description+$ PropertyChanged=�5Q      �� 5R   
   $��	20 20 0 0q�6   $��2��6)   $��0��66   $��2��6F   $ 
Horizontal=�6Z   ��5S      �� 5T      " ��6   .�5U      ��  � y�$ 	Collapsed=�63    5V      �� 5W       6&   �� *	IsAdmin+ True6B   .a�5X      ��  � y�$ Visible=�6;   5Y      5[      .+�5]      �� .+�5^      �� $ 
Horizontal=�6   .+�5_      �� #��[ 6   $��Количество:��6C   �� 5`      #��[ 6   $	��100��6?   ��6K   �� *CurrentGood.StockQuantity+$ PropertyChanged=�$ TwoWay=�5a      �� 5b      $ 
Horizontal=�6   .+�5c      �� #��[ 6   $ ��Всего продано:��6C   �� 5d      #��[ 6   ��6C   �� *CurrentGood.SaledAmount+5e      �� 5f      $ 
Horizontal=�6   .+�5g      �� #��[ 6   $ ��Всего отзывов:��6C   �� 5h      #��[ 6   ��6C   �� *ReviewsNumber+5i      5j      �� 5k      $ 
Horizontal=�6   ��5l      �� 5m      " ��6    5n      �� 5o       6*   �� *	IsAdmin+	 false6F   .a�5p   "   ��  � y�$ 	Collapsed=�6?   5q      5s      .+�5u      �� $0��*pack://application:,,,/Resources/trash.png��6   $��64��6L   $��64��6X   ��5v      �� 5w      " ��6    .�5x      ��  � y�$ Visible=�6;    5y      �� 5z   "    6.   �� *
IsUpdate+$ PropertyChanged=� True6p   .a�5{   &   ��  � y�$ 	Collapsed=�6C   5|   #   5~       5�        5�      $ 	MouseDown��6)   .	 5�        
 64   �� *
DeleteGood+5�      5�      �� 5�      $/��)pack://application:,,,/Resources/edit.png��6   $��64��6K   $��64��6W   ��5�      �� 5�      " ��6    .�5�      ��  � y�$ Visible=�6;    5�      �� 5�   "    6.   �� *
IsUpdate+$ PropertyChanged=� True6p   .a�5�   &   ��  � y�$ 	Collapsed=�6C   5�   #   5�       5�        5�      $ 	MouseDown��6)   .	 5�           CommandParameter$
 True��6S   
 64   �� *
UpdateGood+6S   5�      5�      �� 5�      $/��)pack://application:,,,/Resources/save.png��6   $��64��6K   $��64��6W   ��5�      �� 5�      " ��6    .�5�      ��  � y�$ Visible=�6;    5�      �� 5�   "    6.   �� *
IsUpdate+$ PropertyChanged=�	 False6p   .a�5�   &   ��  � y�$ 	Collapsed=�6C   5�   #   5�       5�        5�      $ 	MouseDown��6)   .	 5�        $ False��6S   
 64   �� *
UpdateGood+6S   5�      5�      5�      5�      �� 5�   
   $��1��6   $��1��6"   $��2��63   $��2��6G   $��20 0 0 0q�6X   ��5�      �� 5�      " ��6    5�      �� 5�       6&   �� *
IsUpdate+ true6C   .a�5�      ��  � y�$ 	Collapsed=�6;   5�      5�      .+�5�      �� #��[ 6   $��Отзывы��6?   $��Center=�6M   5�      �� 5�      $��0q�6   $	��250��6J   $��Visible=�6W   $��Stretch=�6�   $��Stretch=�6�   ��6*   �� *	Reviews+ 5�        AppleStyleScrollBarStyle��%z   '��       7  �� 5�      " ��6   .�5�      ��  � ��8   65   �� 5�       � ��$ Hidden=�6J   5�      5�      ��5�      �� 5�      " ��6   .�5�      ��  �@�Tag 60   �� *DataContext.IsAdmin+ �� RelativeSource ��  �� AncestorType" ���� 5�       � �� 5�      �� 5�   "    �� 
TargetType" ��62   .R�5�   &   �� $��_Border��6-    �� Padding$ 2q�6<    J� SnapsToDevicePixels$
 true��6H   ._�5�   *   �� 5�   '    �� Triggers 5�   &   ^� 5�   *     ^� 
Conditions  5�   .   �� 5�   2   ! �� Binding! 6<   �� *Tag+ �� *Self+" �� Value" True6z   �� 5�   2   ! 6<   �� # �� Path$# 
IsSelected� �� *Self+" True6�   .0�5�   .   �� $ �� 
TargetName$$ _Border��65    � ��
 �  ��6`   5�   +   ^� 5�   *     5�   .   �� 5�   2   ! 6<   �� *Tag+ �� *Self+	" False6z   �� 5�   2   ! 6<   �� $# 
IsSelected� �� *Self+" True6�   .0�5�   .   �� $$ _Border��65    � ��
 ���� 6`   5�   +   5�   #   5�      5�      ��5�      �� 5�      .R�5�      A� % A� Columns$% 1��6&   5�      ��5�      �� 5�      .R�5�      �� 
���   �$��1q�65   $��5q�6I   $ 5q�6T   ._�5�      �� .+�5�   "   �� $ 
Horizontal=�6-   .+�5�   &   A� $��70��6.   $��70��6:   $	��Top=�6E   ��5�   *   �� 5�   .   & �� ImageSource& 69   �� *
User.Image+$ PropertyChanged=�5�   '   �� 5�   &   $��10 0 0 0q�61   .+�5�   *   �� $��
Montressat)�6O   $��16(�6g   ��64   �� *	User.Name+6g   �� 5�   *   $
��Bold"�6J   $��13(�6\   ��64   �� *Date+6\   �� 5�   *   $ 
Horizontal=�65   .+�5�   .   �� $
��Bold"�6P   $��0 0 5 0q�6b   $��13(�6s   ��68   �� *Rating+6s   �� 5�   .   $��out of 5��68   $��13(�6H   5�   +   5�   '   5�   #   �� 5�   "     
ReviewText#���  6I   ��6,   �� *Description+6I   5�      5�      5�      5�      5�      5�      5�      