# Kethmi_Holdings
Kethmi Holdings Land Sale Project

1. Try to insert a project with null fields for costofpurchase tab etc. There is an error saying 'Cannot convert varchar to numaric'. To avoid this, we need to set initial values as 0.00 for all the value text boxes. (Gimantha has already done that) but plz chekc the cleardata method. Gimantha has cleared all the textboxes. Please check and set the value inserting text boxes values to 0.00 in the cleardata method. 

2. I have inserted the SQL Transaction methods to the Mode == 'New' part. Please refer the way and add transaction method to Update process. (Since we cannot use the db class for transaction process, please note - Get the IDs or select queries with a new db connection.)

3.Total cost text boxes has to be updated when the user inserts values. (Handle the textchange event and calculate and print total to total textboxes.)
	- Basic Details (Sellable Area)
	- Cost of Purc (Total cost of purc, Total survay )
	- Dev and util (Tot Dev, Tot util)
	- Travelling and Ad (Tot travel, Tot ad)
	- Just leave the cost sales tab as it is
