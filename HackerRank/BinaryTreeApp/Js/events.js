function documentReady() {
    $(".label").kendoNumericTextBox({});

    $(".button").kendoButton();

    createDiagram();
}

var bst = { name: null, items: [{}, {}] };
function addKeyEvent() {
    var key = parseInt($('#currency').val(), 10);
    addKey(key, bst);
    createDiagram();
};
function refreshEvent () {
    createDiagram();
}

function removeKeyEvent() {
    var key = parseInt($('#currency').val(), 10);
    removeKey(key, bst);
    createDiagram();
}

function randomsEvent()
{
    var count = parseInt($('#randomNumbers').val(), 10);
    var hash = {};
    while (count > 0) {
        var newK = Math.floor((Math.random() * 200) + 1);
        if (!(newK in hash)) {
            addKey(newK, bst);

            hash[newK]= true;
            count--;
        }
    }

    createDiagram();
}

function createDiagram2() {
    var dataSource = new kendo.data.HierarchicalDataSource({
        data: [bst]
    });

    $("#diagram").kendoTreeMap({
        autoBind: true,
        dataSource: dataSource,
        valueField: "name",
        textField: "name"
    });

    dataSource.read();
}

function createDiagram() {
    var dataSource = new kendo.data.HierarchicalDataSource({
        data: [bst]
    });

    $("#diagram").kendoDiagram({
        dataSource: [bst],
        schema: {
            model: {
                children: "items"
            }
        }
        ,
        layout: {
            type: "tree",
            subtype: "down",
            horizontalSeparation: 30,
            verticalSeparation: 20
        },

        shapeDefaults: {
            width: 40,
            height: 40,
            visual: visualTemplate
        }
    });

    dataSource.read();
}

function visualTemplate(options) {
    var dataviz = kendo.dataviz;
    var g = new dataviz.diagram.Group();
    var dataItem = options.dataItem;

    g.append(new dataviz.diagram.Rectangle({
        width: 40,
        height: 40,
        stroke: {
            width: 0
        },
        fill: {
            gradient: {
                type: "linear",
                stops: [{
                    color: dataItem.colorScheme,
                    offset: 0,
                    opacity: 0.5
                }, {
                    color: dataItem.colorScheme,
                    offset: 1,
                    opacity: 1
                }]
            }
        }
    }));

    g.append(new dataviz.diagram.TextBlock({
        text: dataItem.name,
        x: 13,
        y: 13,
        fill: "#fff"
    }));

    return g;
}

function diagramNodes() {
    var root = { name: 10, items: [{ name: 3, items: [{ name: 0 }] }, { name: 15, items: [{ name: 11 }, { name: 20 }] }] };
    return [root];

}
