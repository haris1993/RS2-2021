import 'package:flutter/material.dart';

void main() {
  runApp(
    MaterialApp(
      home: Home(),
    )
  );
}

class Home extends StatefulWidget {
  const Home({Key? key}) : super(key: key);

  @override
  _HomeState createState() => _HomeState();
}

class _HomeState extends State<Home> {
  int counter = 0;
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Home'),
        centerTitle: true,
        backgroundColor: Colors.pink[600],
      ),
      body: Center(
          child: Padding(
            padding: EdgeInsets.fromLTRB(20, 150, 20, 0),
            child: Container(
              child: Column(
                children: [
                  Image(
                    image: AssetImage('assets/image1.jpg'),
                  ),
                  /*Text('counter:',
                    style: TextStyle(
                      fontSize: 35
                    ),
                  ),
                  Text('$counter',
                    style: TextStyle(
                      fontSize: 30
                    ),
                  )*/
                ],
              ),
            ),
          )
      ),
      floatingActionButton: FloatingActionButton(
        onPressed: (){
          counter++;
        },
        child: Text('click'),
        backgroundColor: Colors.pink[600],
      ),
    );
  }
}
