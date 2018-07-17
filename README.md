Hobby project to trade cryptos or other assets based on Google Trends or Twitter popularity.

Inspired by this great talk by Tobias Preis:
https://www.youtube.com/watch?v=nwk0mfpOi_s

Not finished at all.

Loading of data (from disk or from the web):
![Screenshot showing data loading](/img/add_stream.PNG)

Optimizing the strategy parameters. The program assumes a very simple trading strategy:
![Screenshot showing optimization dialog](/img/optimize.PNG)

IF the value of the causal stream (say, the popularity of some search term on Google) changes by more than X, THEN put all your money in the asset and hold for Y amount of time. Shown below is a surface plot of the returns (not accounting for trading fees etc.) if you had used values X and Y for the data that the program currently sees.