   M S B A M L   `   `   `  ����?  ;Lab4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab4Lab4  5      1clr-namespace:Lab4.ViewModelsLab4.ViewModels  5          Lab4.Selected   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $localclr-namespace:Lab4     5      4
viewmodelsclr-namespace:Lab4.ViewModels     5      .��5
      �    	GridTheme#���   6     � RowDefinitions  5   
   �� 5      6   �� 5      6    � 	Resources 5   
    �� 
TargetType �� Property �� Value��%�   '��       �� 5      " ��6   .�5      ��  � ��$ 18(�6-   �� 5       � ��$ Verdana)�6/   �� 5       �@��TextAlignment$ Center=�62   �� 5       � ��$ 10q�6+   �� 5       � ��$
 Wrap=�61   5      5      .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $
��3.5* �6#   �� 5      .+�5      �� -   5         ��Name$ image��5   $   $��0��6   $��0��63   $��15q�6f   ��6@   �� *SelectedGood.Image+6f   � 5      $��1��6     5      �� 5       �� 5!      .+�5#      �� $��0��6   ��6&   �� *
DeleteGood+.��5$      ��  �� TextAlignment$ Center=�6    $��Center=�67     DeleteT#���  6R   5%      �� 5&      $��1��6   ��6&   �� *
EditGood+.��5'      �� $ Center=�6    $��Center=�67    	 EditT#���  6R   5(      5)      5*      �� 5+   
   -   5         ��Name$ scrollViewer��5+      $��1��6-   $
��Auto=�6:   .��5,      �� -   5        	 ��Name$	 
stackPanel��5,        
PanellGrid#���  6-   $��0,0,0,0q�6w   $��Stretch=�6�   
 � DataContext
 6R   �� *SelectedGood+.+�5-      �� �� 5.       	 NameT#���  6   $��0q�6;    �� 5/      $��0q�66   ��6   �� *
FullName+66   50      �� 51      �� 52        	CategoryT#���  6   $��0q�6?    �� 53      $��0q�69   ��6   �� *CategoryStr+69   54      �� 55      �� 56        DescriptionT#���  6   $��0q�6B    �� 57      $��0q�69   ��6   �� *Description+69   58      �� 59      �� 5:       
 ColorT#���  6   $��0q�6<    �� 5;      $��0q�66   ��6   �� *
ColorStr+66   5<      �� 5=      �� 5>       
 PriceT#���  6   $��0q�6<    �� 5?      $��0q�63   ��6   �� *Price+63   5@      �� 5A      �� 5B       	 
AvailableT#��� 	 6   $��0q�6@    �� 5C      $��0q�69   ��6   �� *IsAvailable+69   5D      5E      5F      5G      5H      