   M S B A M L   `   `   `  ���� W  SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XRoyWpf.Behaviors.MessengerTrigger, Version=0.1.2.0, Culture=neutral, PublicKeyToken=nullJ FRoyWpf.Packages, Version=0.1.3.0, Culture=neutral, PublicKeyToken=nullK GRoyWpf.Utilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   ComboBoxToggleButton  �� 
TargetType � ColumnDefinitions ��Name �� CornerRadius F�Name  ComboBoxTextBox  ComboBoxStyle �� 
TargetType �� Property �� Value �� 	ClickMode	 d� 	IsChecked
 �� Path �� Mode �� RelativeSource J� IsHitTestVisible �� SelectionBoxItem �� SelectionBoxItemTemplate ��Name �� 
IsReadOnly �� 
IsReadOnly �� IsDropDownOpen � AllowsTransparency J� SnapsToDevicePixels � ActualWidth �� MaxDropDownHeight K� IsItemsHost-   'System.Windows.Input.KeyboardNavigation    DirectionalNavigation �� Triggers P� Property P� Value �� 
TargetName P� 
SourceName �� Triggers  �� Padding  TextBlockCollapsed! �� Binding" �� UpdateSourceTrigger# �� Value  DescriptionGood$ ��Name% �� AncestorType  
ReviewText  TextBoxGood  ComboBoxCollapsed  CustomScrollViewer& � RowDefinitions' �� ScrollableHeight( � Maximum) �� Orientation* �� VerticalOffset+ � Value, �� ViewportHeight- �� ViewportSize 	 CustomScrollBar. �� ScrollableWidth/ �� HorizontalOffset0 �� ViewportWidth1 ]�Name2 ]� DecreaseRepeatButton3 �� LineUpCommand4 �� ElementName5 ]� IncreaseRepeatButton6 �� LineDownCommand7 ]� Thumb 
 CustomThumb  ScrollBarDisabledBackground8 �� Color  VerticalScrollBarPageButton  ScrollBarThumb  HorizontalScrollStyle9 �Name: J� IsMouseOver; �� PageUpCommand< �� PageDownCommand= � Cursor $  AppleStyleVerticalScrollBarStyle  AppleStyleScrollBarStyle> ��Name? ��Name@ �� CanContentScrollA �� CanHorizontallyScrollB �� CanVerticallyScrollC ��Name*D �� #ComputedVerticalScrollBarVisibility4   .System.Windows.Automation.AutomationPropertiesE   AutomationIdF � Minimum,G �� %ComputedHorizontalScrollBarVisibility�� L 9http://schemas.microsoft.com/winfx/2006/xaml/presentation         :x,http://schemas.microsoft.com/winfx/2006/xaml      %�  &	        &	 A    &	 }    7   7  '��     &	 t    &	 Z	    &	 �    &	 �    &	 3    7   7  &	 z    &		 '    &	
 G    &	 �    &	 �    &	 n    &	     7  7  7  7  &	 5    7  7  &	     �� "  d�.R��  �� �� $��20 �.+��� $ Border��$��2��$ 0�����	#FF3F3F3F���	#FF97A0A5$��1q��� $��0��$ 0��$��1q����	#FF3F3F3F���	#FF97A0A5$��0,0,1,0q�F� $ Arrow��$��1��
�������$��Center=�$��Center=�=����        �    �� � 	= ��[ � z �� � z     � 	=  	= 	�� "  ��.R��� $ PART_ContentHost��$|�False��#��z���� " ��.���  �@J�SnapsToDevicePixels$
 true����  �@�OverridesDefaultStyle$
 true����  � ��$
 Auto=���  � ��$
 Auto=���  � ��$
 true����  � ��$	 120����  � ��$ 20����  � ��
 �������  � �� �� "  ��.R�� .+�d� $��ToggleButton��8��  $��2��$|�false��$ Press=�	 �� $
 IsDropDownOpen�$ TwoWay=� �� *TemplatedParent+�� $��ContentSite��$ False��#��z #��z #��z��$��3,3,23,3q�$��Center=�$
��Left=��� $ PART_EditableTextBox��8�� $
��Left=�$��Center=�$��3,3,23,3q�$
|�True�����	#FF3F3F3F
��� � �$y�Hidden=�# z ��Z� � $��Popup��$��Bottom=�#��z $
 True��$|�False��$��Slide=�.��� $��DropDown��$
 True��#��z #��z .+��� $ DropDownBorder�����	#FF3F3F3F$��1q����#888888�� $��4,6,4,6q�$
 True��.���� $
 True��$ 	Contained=� P�  �@��HasItems$ false��. ��� $ DropDownBorder�� � ��$ 95��P�  � {�$ false��. ���  � �� �#888888P�  �@��
IsGrouping$
 true��. ���  � ��$ false��P� $ Popup�� �@�AllowsTransparency$
 true��. ��� $ DropDownBorder�� �@��CornerRadius$ 0���� $ DropDownBorder�� � ��$ 0,2,0,0q�P�  �@��
IsEditable$
 true��. ���  � ��$ false���� $ PART_EditableTextBox�� � y�$ Visible=��� $ ContentSite�� � y�$ Hidden=� �� " ��.���  �@J�SnapsToDevicePixels$
 true����  � ��
 �������  �@�OverridesDefaultStyle$
 true����  � �� �� "  ��.R��� $��Border��$  2q�$
 true��._���  P�  �@��IsHighlighted$
 true��. ��� $ Border�� � �� �	#FF4F4F4FP�  � {�$ false��. ���  � �� �#888888�� " ��.���  � ��$ 16(���  � ��$
 Bold"���  � ��$ 30����  � ��$ 0 0 20 0q���  � y�$ Visible=� �� ! �� *
IsUpdate+$" PropertyChanged=�# True.a���  � y�$ 	Collapsed=��� " ��.���  � ��$ 16(���  � ��$ SemiBold"���  � ��$
 Auto����  � ��$	 400����  � ��
 �������  � ��$ 2q���  � ��$ 0 0 20 0q���  � �� �� "  ��.R��� 
���   �$��1q�$ 5��._�� .+��� $$ PART_ContentHost��$|�false��$��Center=�$
��Auto=�$��Hidden=� �� ! �� *
IsUpdate+$" PropertyChanged=�	# false.a���  � ��$ 0q���  �@��
IsReadOnly$
 True����  � �� �� *
Background+ �� *FindAncestor+"% ���� ! �� *
IsUpdate+$" PropertyChanged=�# true.a���  � ��$ 2q���  �@��
IsReadOnly$ False����  � ��
 ������� " ��.���  � ��$ 14(���  � ��$ 
Montressat)���  � ��$
 Auto����  � ��$	 400����  � ��$ 0 10 0 0q���  � ��$
 Wrap=��� " ��.���  � ��$ 16(���  � ��$ SemiBold"���  � ��$
 Auto����  � ��$	 450����  � ��
 �������  � ��$ 2q���  � ��$ 0 0 20 0q���  � �� �� "  ��.R��� #��z��#��z��#��z��$ 10��._�� .+��� $$ PART_ContentHost��$|�false��$��Center=�$
��Auto=�$��Hidden=� �� ! �� *
IsUpdate+$" PropertyChanged=�	# false.a���  � ��$ 0q���  �@��
IsReadOnly$
 True����  � �� �� *
Background+ �� *FindAncestor+"% ���� ! �� *
IsUpdate+$" PropertyChanged=�# true.a���  � ��$ 2q���  �@��
IsReadOnly$ False����  � ��
 ������� " ��.���  �@J�SnapsToDevicePixels$
 true����  �@�OverridesDefaultStyle$
 true����  � ��$
 Auto=���  � ��$
 Auto=���  � ��$
 true����  � ��$	 200����  � ��$ 	0 15 20 0q���  � ��$
 Left=���  � ��$ 20����  � ��
 �������  � y�$ 	Collapsed=���  � �� �� "  ��.R�� .+�d� $��ToggleButton��8��  $��2��$|�false��$ Press=�	 �� $
 IsDropDownOpen�$ TwoWay=� �� *TemplatedParent+�� $��ContentSite��$ False��#��z #��z #��z��$��3,3,23,3q�$��Center=�$
��Left=��� $ PART_EditableTextBox��8�� $
��Left=�$��Center=�$��3,3,23,3q�$
|�True�����	#FF3F3F3F
��� � �$y�Hidden=�# z ��Z� � $��Popup��$��Bottom=�#��z $
 True��$|�False��$��Slide=�.��� $��DropDown��$
 True��#��z #��z .+��� $ DropDownBorder�����	#FF3F3F3F$��1q����#888888�� $��4,6,4,6q�$
 True��.���� $
 True��$ 	Contained=� P�  �@��HasItems$ false��. ��� $ DropDownBorder�� � ��$ 95��P�  � {�$ false��. ���  � �� �#888888P�  �@��
IsGrouping$
 true��. ���  � ��$ false��P� $ Popup�� �@�AllowsTransparency$
 true��. ��� $ DropDownBorder�� �@��CornerRadius$ 0���� $ DropDownBorder�� � ��$ 0,2,0,0q�P�  �@��
IsEditable$
 true��. ���  � ��$ false���� $ PART_EditableTextBox�� � y�$ Visible=��� $ ContentSite�� � y�$ Hidden=� �� ! �� *
IsUpdate+$" PropertyChanged=�# True.a���  � y�$ Visible=��� " ��.���  �@�OverridesDefaultStyle$
 True����  � �� �� "  ��.R��  �� $
��Auto ��� $��* �& �� $
��Auto ��� $��* �.+��� $��PART_VerticalScrollBar��$��1��#( z' $) Vertical=�#+ z* #- z, #��� 	 $��10��$��0q�$
 True���� $��PART_HorizontalScrollBar��$��1��#( z. $) 
Horizontal=�#+ z/ #- z0 #��� 	 $��10��$��0q�$
 True���� $��0��$��0��$��2��#��z���� " ��.���  � ��
 ���� ��  � ��
 �������  � ��$ 8����  � �� �� "  ��.R�� .+��� $ Corner��#��z��]� $1 
PART_Track��2 �� #��Z3 ���� $4 PART_ScrollViewer��5 �� #��Z6 ���� $4 PART_ScrollViewer��7 n� #��z��#��� 
 �� " n�.���  � ��
 �������  � �� �� "  n�.R��� #��z��$ 5���� $8 #F4F4F4���� " ��.���  �@�OverridesDefaultStyle$
 true����  � ��
 ���� ��  � |�$ false����  � ��$ false����  � �� �� "  ��.R��� #��z��#��z��#��z���� " n�.���  �@�OverridesDefaultStyle$
 true����  � ��$ false����  � �� �� "  n�.R��� ���	#FF868686$��0,0,1,0q�$
��Auto��$ 4���� " ��.���  � ��
 ���� ��  � �� �� "  ��.R�� $9 Bg��#��z��$��10��$
 true��& �� .+�]� $1 
PART_Track��$
��true��#{�z: 2 �� #��Z; 8��  5 �� #��Z< 8�� 7 n� 8�� $
= Hand�� P�  � {�$ false��. ��� $ Bg��8   � ���� " ��.���  � �� �� "  ��.R�� $9 Bg��$
 true��$��10��$��Right=�$��0q�& �� .+�]� $1 
PART_Track��$
��true��#{�z: 2 �� #��Z; 8��  5 �� #��Z< 8�� 7 n� #���  $
= Hand���� "  ��.R�� $
9 Grid��#��z�� �� $��* ��� $
��Auto �& �� $��* ��� $
��Auto �.+��� $> Corner��$��1��$��1����Z� �� $!? PART_ScrollContentPresenter��#@ z��$A False��$B False��#��z��#��z��$��0��#��z��$��0���� $C PART_VerticalScrollBar��#y�zD $E VerticalScrollBar��$= Arrow��$��1��#( z' $F 0Q�$��0��#- z, #���  $
��Auto��$��0q�+ �� *VerticalOffset+$ OneWay=� �� *TemplatedParent+��Z� �� $C PART_HorizontalScrollBar��#y�zG $E HorizontalScrollBar��$= Arrow��$��0��#( z. $F 0Q�$) 
Horizontal=�$��1��#- z0 #���  + �� *HorizontalOffset+$ OneWay=� �� *TemplatedParent+