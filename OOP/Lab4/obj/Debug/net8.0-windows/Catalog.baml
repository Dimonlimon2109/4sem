   M S B A M L   `   `   `  ����?  ;Lab4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab4Lab4  5      1clr-namespace:Lab4.ViewModelsLab4.ViewModels  6/       Lab4.Catalog   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $localclr-namespace:Lab4     5      4
viewmodelsclr-namespace:Lab4.ViewModels     6/   .��5	      �   � ShowGridLines$  False��6   .+�5
   
   �� -   5        $��Items��5
   &   $��0q�6   $��False��6w   $��Visible=�6�   $��Disabled=�6�   $��Stretch=�6  $��Stretch=�6+     	ListTheme#���   6N   �� SelectedItem 63   �� *SelectedGood+��6Y   �� *Goods+��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value �#BBBBBB63   �� 5       � �� 5      �� 5       �� 
TargetType" ��6.   .R�5   "   �� $��5q�63   5      5       �� Triggers 5      �� 5       �� Binding 6&   �� *Theme+ �� Value 06@   .a�5      ��  � �� �#BBBBBB6;   5      �� 5       6&   �� *Theme+ 16@   .a�5      ��  � ��
 ����6;   5      �� 5       6&   �� *Theme+ 26@   .a�5      ��  � ��
 ��  �6;   5      P� 5      	 P� Property	 �@J�IsMouseOver
 P� Value$

 True��69   . �5       ��  �@�Cursor$
 Hand��67   �� 5!       � �� �#D9D9D96;   5"      5$      ��5&      �� 5'      .R�5(      A�  A� Columns$ 3��6"   5)      ��5+      �� 5,      .R�5-      �� $��2,2,2,2q�6   ��67   �� *
Background+ �� RelativeSource �� *FindAncestor+ �� AncestorType" �� � 	Resources 5.      ��%    5/      ._�50      �  51      ��%{   '��       �� 52   "   " ��6(   .�53   &   ��  � ��$ 18(�6A   �� 54   &    � ��$ Verdana)�6C   55   #   56       � RowDefinitions 57      �� 58   "   $��3* �60   �� 59   "   $
��0.5* �60   �� 5:   "   $
��0.5* �60   �� 5;   "   $
��0.5* �60   .+�5=      �� $��0��6%   $��Stretch=�6K   $��20q�6g   ��62   �� *Image+6g   �� 5>      $��1��6(   $
��Wrap=�65    �� TextAlignment$
 Left=�6I   $��20q�6y   ��6^   �� *	ShortName+6y   �� 5?      $��2��6(   $
 Left=�65   $��20q�6J   �� 5@       
 PriceT#���  6(    �� 5A      ��6(   �� *Price+6A    �� 5B        	CurrencyT#���  6(   5C      �� 5D      $��3��6(   $
 Left=�65   $��20q�6J   �� 5E        RatingT#���  6(    �� 5F      ��6(   �� *Rating+ �� StringFormat$ {0}/5��5G      5H      5I      5J      5L      5M      5N      