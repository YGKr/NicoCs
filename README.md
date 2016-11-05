# NicoCs

C#から手軽にniconicoAPIを使うことができるようにするライブラリです

#使い方

## NicoCs.Movie.MovieInfo

動画に関する情報を扱うことができます。

### GetMovieInfo(string ID)

動画の情報を取得します。
IDは"sm..."等の形式です。

以下の情報を取得することができます。

VideoID  
Title  
Description  
ThumbnailURL  
FirstRetrieve  
Length  
MovieType  
Size  
Size_Low  
ViewCount  
CommentNumber  
MylistCount  
LatestComment  
WatchURL  
ThumbnailType  
Embeddable  
NoLivePlay  
UserID  
UserNickName  
UserIconURL  
ChannelID  
ChannelName  
ChannelIconURL  
Tags  

#### Example

`NicoCs.Movie.MovieInfo movie = new NicoCs.Movie.MovieInfo();`
`movie.GetMovieInfo("smhoge");`
`System.Console.WriteLine(movie.UserID);`

## NicoCs.Image.User

ニコニコ静画のユーザーに関する情報を扱うことができます。

### NicoCs.Image.User.GetUserData(string ID)

ユーザーの情報を取得します。

IDは"11111"等の形式です。

以下の情報を取得することができます。

id  
NickName  

#### Example

`NicoCs.Image.User user = new NicoCs.Image.User();`  
`user.GetUserData("11111");`  
`System.Console.WriteLine(user.NickName);`  
