   M S B A M L   `   `   `  ����M  IMortgageCalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:MortgageCalculatorMortgageCalculator  5   	   #    MortgageCalculator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:MortgageCalculator     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ 	lbl_Title��5
      $��Mortgage Calculator��6#   $
��Left=�6A   $��	53,17,0,0q�6\   $	��Top=�6o   $��24(�6�   �� 5   
   -   5        $ lbl_MonthlyCost��5      $��Monthly cost��6)   $
��Left=�6@   $��	53,57,0,0q�6[   $	��Top=�6n   �� 5   
   -   5        $ 
lbl_Period��5      $��Period��6$   $
��Left=�65   $��
358,91,0,0q�6P   $	��Top=�6d   �� 5   
   -   5        $ lbl_Interest��5      $��
Interest %��6&   $
��Left=�6;   $��
200,91,0,0q�6V   $	��Top=�6j   �� 5   
   -   5        $ 
lbl_Amount��5      $��Mortgage Amt��6$   $
��Left=�6;   $��	53,91,0,0q�6V   $	��Top=�6i   �� 5   
   -   5        $ lbl_MonthlyPayments��5      $��Monthly Payments��6-   $
��Left=�6H   $��
53,161,0,0q�6c   $	��Top=�6w   �� 5   
   -   5         ��Name$ Amount��5      $
��Left=�6"   $��23��6=   $��
53,117,0,0q�6I    �� TextWrapping$
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $	��120��6�   �� 5   
   -   5        $ MonthlyPayments��5      $
��Left=�6+   $��23��6F   $��366,165,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��120��6�   �� 5   
   -	   5        $ Period��5      $
��Left=�6"   $��23��6=   $��358,117,0,0q�6I   $
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��120��6�   �� 5   
   -
   5        $ Interest��5      $
��Left=�6$   $��23��6?   $��200,117,0,0q�6K   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   �� 5   
   -   5         ��Name$ btn_Calculate��5      $��	Calculate��6(   $
��Left=�6<   $��408,224,0,0q�6W   $	��Top=�6l   $��75��6�   �� 5   
   
���   �$��1q�6%   $
��Left=�69   $��74��6T   $��	53,17,0,0q�6`   $	��Top=�6s   $	��433��6�   5      5      