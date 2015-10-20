function addKey(mykey, bst) {

    var head = bst;
    var node;
    var newNode;
    if (head.name == null) {
        head.name = mykey;
        head.items = [{}, {}];
        return;
    }
    else {
        newNode = { name: mykey, items: [{}, {}] };;
        node = head;
        var parent = node;
        while (node.name != null) {
            if (node.name < newNode.name) {
                parent = node;
                node = parent.items[1];  //r
            }
            else {
                parent = node;
                node = parent.items[0];   //l
            }
        }

        //if (parent.name.CompareTo(myKey) <= 0) {
        //    items[1] = newNode;
        //}
        //else {
        //    items[0] = newNode;
        //}
        node = newNode;
    }
}

function removeKey(key, bst) {

}