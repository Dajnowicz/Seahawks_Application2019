   M S B A M L   `   `   `  ���� F  BSeahawksApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SeahawksAppSeahawksApp      SeahawksApp.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:SeahawksApp       � Title$  Seahawks App��$	��517��$	��956�� � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � Icon$ Files/HOME/icon.png�� � 	Resources  �� DataType   SeahawksApp.Home   SeahawksApp.History   SeahawksApp.Players   SeahawksApp.Photos   SeahawksApp.Results   
ScaleStyle �� 
TargetType �� Triggers	 P� Property
 P� Value �� Property �� Value �� ScaleX �� ScaleY  ScaleStyleImage  MyButtonStyle �� 
TargetType �� Triggers��%  (��       *, +)(��      *, +)(�� 9     *, +)(�� W     *, +)(�� t     *, +)&	  �     &	 	    &	 �    �� HomeTemplate��"  �� HistoryTemplate��"  �� PlayersTemplate��"  �� PhotosTemplate��"  �� ResultsTemplate��"  �� " �� P� 	 �@J�IsMouseOver
 . . ���  �@K�ZIndex$ 1����  � z� �� $	 1.1Q�$	 1.1Q��� " �� P� 	 �@J�IsMouseOver
 . . ���  �@K�ZIndex$ 1����  � z� �� $	 1.5Q�$	 1.5Q��� " ��.���  �@�OverridesDefaultStyle . ��  � ��$ 5q���  � �� �� " ��.R��� $��border��#��z��._��� $��Center=�$��Center=� P� 	 �@J�IsMouseOver
 . . ���  �@�Cursor$
 Hand����  �@K�ZIndex$ 1����  � z� �� $	 1.2Q�$	 1.2Q�.��� .+��� $
��Left=�$	��238�����	#FFFFCA05$��0,0,0,52q�.+��� #��[   J� RenderTransformOrigin$ 0.5,0.5&�$
��Wrap=�$��WE THE NORTH��$��Bottom=�$��0,45,0,0q�$��Center=�$	��Top=�$��Fragua)�$
��Bold"�$��36(�$��Italic$� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 25Q��� -    ��Name$ 
HomeButton��#��[ $ 0.5,0.5&�$
��HOME��$��Fragua)�$��32(�$
��Bold"�
�������$��0,61,0,0q���Z� �� -   $ HistoryButton��#��[ $ 0.5,0.5&�$��HISTORY��$��Fragua)�$��32(�$
��Bold"�
�������$��0,15,0,0q���Z� ��Z� �� -   $ DefPlayersButton��#��[ $ 0.5,0.5&�$��DEFENSIVE PLAYERS��$��Fragua)�$��24(�$
��Bold"�
�������$��0,15,0,0q���Z� ��Z� �� -   $ OffPlayersButton��#��[ $ 0.5,0.5&�$��OFFENSIVE PLAYERS��$��Fragua)�$��24(�$
��Bold"�
�������$��0,15,0,0q���Z� ��Z� �� -   #��[ $ 0.5,0.5&�$��PHOTOS��$��Fragua)�$��32(�$
��Bold"�
�������$��0,15,0,0q���Z� ��Z� �� -   #��[ $ 0.5,0.5&�$��	NEXT GAME��$��Fragua)�$��32(�$
��Bold"�
�������$��0,15,0,0q���Z� ��Z� ]� $��9����.  $��	230,0,0,0q�$	��Top=����	#FFFFCA05]� $
��Left=�$	��120����.  $��	238,9,0,0q�$	��Top=�$	��718��
���   �.+��� #��[ $ 0.5,0.5&�$��Center=�$��Files/Logo/Warstwa 4.png��$��Center=�$	��390��$��65,7,0,0q�{�.   � Cursor$
 None���� -   #��[ $ 0.5,0.5&�$��39��$��Center=�$��40��$��Center=�$��
42,-13,0,0q���Z� ����  �� ImageSource$ Files/Logo/FB.png���� -   #��[ $ 0.5,0.5&�$��39��$��Center=�$��40��$��Center=�$��
42,-13,0,0q���Z� ���� $ Files/Logo/IN.png��]� $
��Left=�$	��388����.  $��238,129,0,0q�$	��Top=�$	��718��.+��� $	��718��$��Center=�$��Center=�$	��388������ ]� $
��Left=�$��52����.  $��	0,465,0,0q�$	��Top=�$	��238�����	#FFFFCA05.+��� $��Mady by /Dajnowicz��$��Fragua)�$��16(�$
��Bold"�
�������$	��175��$��Center=�$��Center=�$��23�� �� TextAlignment$ Center=�$��	6,18,0,17q���Z� �� -	   #��[ $ 0.5,0.5&�$��Center=�$��Center=�$��34��$��36��$��5,8,5,10q���Z� ���� $ Files/Logo/github.png��