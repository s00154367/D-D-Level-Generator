   M S B A M L   `   `   `  ����G  CMosterGenWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MosterGenWPFMosterGenWPF  5   	       MosterGenWPF.Startup   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:MosterGenWPF     5   	     � Title$  Startup��5   	   $	��450��6   $	��800��6&   .��5	      �  J� OpacityMask �	#FF96FC32��5
   
   �� 5       �� ImageSource$ img/StartupBackground.jpg��6   .+�5   
   �� -   5        $��btnStart��5   �   $��	Showtime!��6   $
��Left=�6%   $��565,330,0,0q�6@   $	��Top=�6U   $	��200��6m   $��60��6y   $��20(�6�   $��Terminator Two)�6�   
���  ��6�   �� 5   
   -   5        $��
cbbPlayers��5   f   $
��Left=�6   $��
35,100,0,0q�6.   $	��Top=�6B   $	��200��6Z   $��20(�6x   $��Stencil)�6�   ��5      �� 5       �� EndPoint$	 0,1&�6&    �� 
StartPoint$	 0,0&�65   .��5      �  � Color$ 	#FFFF0C0C��6#   � 5      $	 Red��6#    � Offset$ 1Q�6/   5      5      �� 5   
   $.��(Welcome to the Tower of Luck'n Assholes!��6   $
��Left=�6C   $��	55,10,0,0q�6^   $	��Top=�6q   $��30(�6�   $��Showcard Gothic)�6�   �� 5   
   $!��Please Choose your Players:��6   $
��Left=�66   $��	35,71,0,0q�6Q   $	��Top=�6d   $��Stencil)�6|   ���	#B2FFFFFF$	��200��6�   �� 5   
   $��Half Speed to stand up.��6   $
��Left=�62   $��
391,69,0,0q�6M   $	��Top=�6a   ���	#BFFFFFFF6y   �� 5   
   $I��CChoose any Non-Magical Starting item in PHB for starting equipment.��6   $
��Left=�6^   $��391,100,0,0q�6y   $	��Top=�6�   ���	#BFFFFFFF6�   �� 5   
   $$��Free Action to switch weapons.��6   $
��Left=�69   $��391,130,0,0q�6T   $	��Top=�6i   ���	#BFFFFFFF6�   �� 5   
   $$��10 mins to move between rooms.��6   $
��Left=�69   $��391,161,0,0q�6T   $	��Top=�6i   ���	#BFFFFFFF6�   �� 5   
   $-��'Long Rests at Rooms with Dead Monsters.��6   $
��Left=�6B   $��391,194,0,0q�6]   $	��Top=�6r   ���	#BFFFFFFF6�   �� 5   
   $��Rooms Are 120ft tall.��6   $
��Left=�60   $��391,224,0,0q�6K   $	��Top=�6`   ���	#BFFFFFFF6x   �� 5    
   -   5         ��Name$ btnRoomSetup��5    �   $��Setup Room!��6   $
��Left=�6'   $��
35,161,0,0q�6B   $	��Top=�6V   $	��200��6n   $��60��6z   $��20(�6�   $��Terminator Two)�6�   ���	#FFE5E5E56�   5#      5$      