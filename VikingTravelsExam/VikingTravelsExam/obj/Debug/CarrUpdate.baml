   M S B A M L   `   `   `  ����L  HVikingTravelsExam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:VikingTravelsExamVikingTravelsExam  5   	   "    VikingTravelsExam.CarrUpdate   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:VikingTravelsExam     5   	     � Title$  
CarrUpdate��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� $��Transportør Updatering��6   $��2��61   $��29(�6E   $��Light"�6S   $
��Left=�6f   $	��Top=�6�   �� 5   
   $��Fornavn��6   $��1��6"   $��25(�6/   $��Center=�6=   $��Bottom=�6Z   �� 5   
   -   5         ��Name$ insertFirstName��5      $��3q�6+   
���iii�$��2��6U   $��5q�6b    �� TextWrapping$
 Wrap=�6m   �� 5   
   $��	Efternavn��6   $��1��6$   $��1��61   $��25(�6A   $��Center=�6O   $��Bottom=�6l   �� 5   
   -   5        $ insertLastName��5      $��3q�6*   
���iii�$��2��6T   $��1��6a   $��5q�6q   $
 Wrap=�6|   �� 5!   
   $��Addresse��6   $��1��6#   $��2��60   $��25(�6@   $��Center=�6N   $��Bottom=�6k   �� 5"   
   -   5        $ insertAddress��5"      $��3q�6)   
���iii�$��2��6S   $��2��6`   $��5q�6p   $
 Wrap=�6{   �� 5$   
   $��Telefon Nummer��6   $��1��6)   $��3��66   $��23(�6F   $��Center=�6T   $��Bottom=�6q   �� 5%   
   -   5        $ insertTelNum��5%      $��3q�6(   
���iii�$��2��6R   $��3��6_   $��5q�6o   $
 Wrap=�6z    �� 	MaxLength$ 15��6�   �� 5'   
   $��Bemærkninger��6   $��3��6'   $��25(�64   $��Center=�6B   �� 5(   
   -   5        $ insertCarrRemarks��5(      $��3q�6-   
���iii�$��4��6W   $��5q�6d   $
 Wrap=�6o   �� 5,   
   -   5         ��Name$ 
updateCust��5,      $��Updater��6%   $��20(�67   $��10q�6E   $��4��6Q   $��3��6^   6n   �� 5-   
   -   5        $ Chancel��5-      $��Annuller��6"   $��20(�65   $��10q�6C   $��4��6O   $��2��6\   6l   �� 50   
   -   5         ��Name$ errorMessage��50      $!��FEJL! UDFYLD ALLE FÆLTER!!��6&   $��Bottom=�6K   $��Right=�6f   $��3��6�   $��3��6�   $��15(�6�   
���  �� J� Opacity$ 0Q�6�   51      52      