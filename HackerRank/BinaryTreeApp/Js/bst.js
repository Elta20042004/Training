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
        var parent;
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

        if (parent.name < newNode.name) {
            parent.items[1] = newNode;
        }
        else {
            parent.items[0] = newNode;
        }
    }
}

function removeKey(key, bst) {

    var head = bst;
    var node = head;
    var parent = node;

    while (node.name != key) {
        if (node.name < key) {
            parent = node;
            node = parent.items[1];  //r
        }
        else {
            parent = node;
            node = parent.items[0];   //l
        }
    }

    if (parent.name == node.name) {
        head = {};
    }
    else if (node.items[1].name != null && node.items[0].name != null) {
        var current = node.items[0];  //l
        var current1 = node.items[0];
        var next = current;
        var father = current;

        while (current.name != null) {
            father = next;
            next = current;
            current = current.items[1];  //r
        }

        if (current1.name == next.name) {

            parent.items[0] = current1;     //r               
            if (node.items[1].name != null) {
                parent.items[1] = node.items[1];   //r
            }
        } else {

            if (parent.name < node.name) {
                parent.items[1] = next;     //r
                next.items[0] = node.items[0];
                father.items[1] = {};
            }
            else {
                parent.items[0] = next;
                next.items[0] = node.items[0];
                father.items[0] = {};
            }

            if (node.items[1].name != null) {
                next.items[1] = node.items[1];   //r
            }
        }


    }
    else if (node.items[1].name == null && node.items[0].name == null) {
        if (parent.name < node.name) {
            parent.items[1] = {};
        }
        else {
            parent.items[0] = {};
        }
    }
    else if (node.items[1].name == null || node.items[0].name == null) {
        var notnull;
        if (node.items[1].name == null) {
            notnull = node.items[0];
        } else {
            notnull = node.items[1];
        }

        if (parent.name < node.name) {
            parent.items[1] = notnull;
        }
        else {
            parent.items[0] = notnull;
        }
    }
}