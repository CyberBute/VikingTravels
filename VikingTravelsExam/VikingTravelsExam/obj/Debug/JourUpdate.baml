   M S B A M L   `   `   `  ����L  HVikingTravelsExam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:VikingTravelsExamVikingTravelsExam  5   	   "    VikingTravelsExam.JourUpdate   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:VikingTravelsExam     5   	     � Title$  
JourUpdate��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� $��Transportør Updatering��6   $��2��61   $��29(�6E   $��Light"�6S   $
��Left=�6f   $	��Top=�6�   �� 5   
   $��Titel��6   $��1��6    $��25(�6-   $��Center=�6;   $��Bottom=�6X   �� 5   
   -   5         ��Name$ insertTitle��5      $��3q�6'   
���iii�$��2��6Q   $��5q�6^    �� TextWrapping$
 Wrap=�6i   �� 5!   
   $��By��6   $��1��6   $��1��6*   $��25(�6:   $��Center=�6H   $��Bottom=�6e   �� 5"   
   -   5        $ 
insertCity��5"      $��3q�6&   
���iii�$��2��6P   $��1��6]   $��5q�6m   $
 Wrap=�6x   �� 5$   
   $��
Start Dato��6   $��1��6%   $��2��62   $��25(�6B   $��Center=�6P   $��Bottom=�6m   (  "System.Windows.Controls.DatePicker  5%   
   -   5          Name$ insertStartDate��5%      $��2��6.   $��2��6>   �� 5'   
   $��Telefon Nummer��6   $��3��6*   $��1��6;   $��23(�6H   $��Center=�6V   $��Bottom=�6s     5(   
   -   5        $ insertEndDate��5(      $��3��6,   $��2��6<   �� 5*   
   $��Max Rejsende��6   $��3��6'   $��25(�64   $��Center=�6B   �� 5+   
   -   5        $ 	insertMax��5+      $��3q�6%   
���iii�$��4��6O   $��5q�6\   $
 Wrap=�6�   �� 5-   
   $��Transportør��6   $��3��6&   $��1��63   $��25(�6C   $��Center=�6Q   �� 5.   
   -   5         ��Name$ insertCarrierNames��5.      $��4��6/   $��1��6<   50      �� 52   
   $��Transportør��6   $��3��6&   $��2��63   $��25(�6C   $��Center=�6Q   �� 53   
   -   5        $ insertPrice��53      $��3q�6'   
���iii�$��4��6R   $��2��6_   $��5q�6o   6z   �� 55   
   $��Beskrivelse��6   $��3��6&   $��3��63   $��25(�6C   $��Center=�6Q   �� 56   
   -   5        $ 	insertDic��56      $��3q�6%   
���iii�$��4��6P   $��3��6]   $��5q�6m   �� 59   
   -	   5         ��Name$ 
updateJour��59      $��Updater��6%   $��20(�67   $��10q�6E   $��6��6Q   $��3��6^   6n   �� 5:   
   -
   5        $ Chancel��5:      $��Annuller��6"   $��20(�65   $��10q�6C   $��6��6O   $��2��6\   6l   �� 5=   
   -   5         ��Name$ errorMessage��5=      $!��FEJL! UDFYLD ALLE FÆLTER!!��6&   $��Bottom=�6K   $��Right=�6f   $��3��6�   $��5��6�   $��15(�6�   
���  ��	 J� Opacity$	 0Q�6�   5>      5?      