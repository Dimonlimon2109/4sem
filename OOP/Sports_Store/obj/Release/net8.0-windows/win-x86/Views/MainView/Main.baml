   M S B A M L   `   `   `  ���� G  CSports_Store, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Sports_storeSports_store  A%clr-namespace:Sports_store.ViewModelsSports_store.ViewModels  \ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35ZAclr-namespace:System.Windows.Shell;assembly=PresentationFrameworkSystem.Windows.Shell     Sports_store.Main   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XRoyWpf.Behaviors.MessengerTrigger, Version=0.1.2.0, Culture=neutral, PublicKeyToken=nullJ FRoyWpf.Packages, Version=0.1.3.0, Culture=neutral, PublicKeyToken=nullK GRoyWpf.Utilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L 9http://schemas.microsoft.com/winfx/2006/xaml/presentation        R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ,localclr-namespace:Sports_store     <
viewmodels%clr-namespace:Sports_store.ViewModels     SshellAclr-namespace:System.Windows.Shell;assembly=PresentationFramework     _	 [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3aW
 SSystem.Windows.Interactivity, Version=0.1.2.0, Culture=neutral, PublicKeyToken=null5i+http://schemas.microsoft.com/xaml/behaviors 	 
   � Title$
  Main��$	��700��$
��1000��
������� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 none=� � DataContext $   Sports_store.ViewModels.MainVM  .���  � RowDefinitions �� $	��100 ��� .+���  �� Orientation$ 
Horizontal=�$	��Top=�
�������.+��� $!��../../Resources/profile.png��$��50 0 0 0q�$��70��$��70��* 	 $Microsoft.Xaml.Behaviors.Interaction   Triggers + 	 %Microsoft.Xaml.Behaviors.EventTrigger     	EventName$ 	MouseDown��* 	 $Microsoft.Xaml.Behaviors.TriggerBase	   Actions.	 2 	 ,Microsoft.Xaml.Behaviors.InvokeCommandAction  
   CommandParameter$
 Profile��   Command �� *
ChangePage+�� $
��Bold"�$��Roboto)�$��40(�$��Center=�$��Каталог��$��200 0 200 0q�   $ 	MouseDown��.	   $
 Catalog�� �� *
ChangePage+�� $��../../Resources/plus.png��$��0 0 20 0q�$��60��$��60������  �� 
TargetType" ��.���  �� Property � y� �� Value$ Visible=� �� Triggers ��  �� Binding �� *CurrentUser.IsAdmin+ �� Value 0.a���  � y�$ Hidden=�   $ 	MouseDown��.	    �� *
AddNewGood+�� $��../../Resources/cart.png��$��70��$��70��$��0 0 0 0q����� " ��.���  � y�$ Visible=� ��  �� *CurrentUser.IsAdmin+ 1.a���  � y�$ Hidden=�   $ 	MouseDown��.	   $
 Basket�� �� *
ChangePage+�� $	��Top=�$��Right=�$��113.5 0 0 49.7q�$ 
Horizontal=�.+��� $��30��$��30��$��0q����� *Hide+���� " ��.���  � �� ��  �� 
TargetType" ��.R�� 
�������.+��� 
���   �$��4��$��15��$��Center=��� $��30��$��30��$��0q����� *Exit+���� " ��.���  � �� �� " ��.R�� 
�������.+�F� 
���   �$��4��+����        р�����Ѐ��    �    ���	�� $��1������ *CurrentUserControl+