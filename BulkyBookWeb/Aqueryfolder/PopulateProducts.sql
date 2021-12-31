Declare @Amazon int = 0; 
select @Amazon =  Id from Vendors v where Code = 'AMZ';
Declare @Walmart int = 0; 
select @Walmart =  Id from Vendors v where Code = 'WAL';
Declare @Barn int = 0; 
select @Barn =  Id from Vendors v where Code = 'BRN';
insert into Products 
	(BookNbr,Title,Author,Price,Unit,VendorId)
		Values
			('f0001','Le Morte D''Arthur','Thomas Malory',12.99,1,@Amazon),
			('f0002','Through the Looking Glass','Lewis Carroll',18.99,1,@Walmart),
			('f0003','Five Children and It','E. Nesbit',13.75,1,@Amazon),
			('f0004','Ozma of Oz','L. Frank Baum',10.99,1,@Amazon),
			('f0005','Mary Poppins','P.L. Travers',5.50,1,@Amazon),
			('f0006','The Lion, The Witch, and The Wardrobe','C.S. Lewis',13.95,1,@Walmart),
			('f0007','The Palm-Wine Drinkard','Amos Tutuola',12.99,1,@Amazon),
			('f0008','The Voyage of the Dawn Treader','C.S. Lewis',13.95,1,@Walmart),
			('f0009','The Fellowship of the Ring','J.R.R. Tolkien',15.99,1,@Barn),
			('f0010','My Life in the Bush of Ghosts','Amos Tutuola',12.99,1,@Amazon),
			('f0011','The Two Towers','J.R.R. Tolkien',15.99,1,@Barn),
			('f0012','The Return of the King','J.R.R. Tolkien',15.99,1,@Barn),
			('f0013','A Hero Born','Jin Yong',21.99,1,@Amazon),
			('f0014','The Once and Future King','T.H. White',12.99,1,@Amazon),
			('f0015','James and the Giant Peach','Roald Dahl',12.99,1,@Walmart),
			('f0016','The Phantom Tollbooth','Norton Juster',8.95,1,@Barn),
			('f0017','A Wrinkle in Time','Madeleine L''Engle',15.25,1,@Amazon);
