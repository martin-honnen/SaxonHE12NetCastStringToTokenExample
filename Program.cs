using net.liberty_development.SaxonHE12s9apiExtensions;
using net.sf.saxon.s9api;

var processor = new Processor();

var docBuilder = processor.newDocumentBuilder();

var xmlDoc = docBuilder.Build(new FileInfo("sample1.xml"));

var xpathProcessor = processor.newXPathCompiler();

var items = xpathProcessor.evaluate("//item/token", xmlDoc);

for (var i = 0; i < items.size(); i++)
{
    var item = items.itemAt(i);
    Console.WriteLine($"string value: |{item.getStringValue()}|; cast as xs:token : |{xpathProcessor.evaluateSingle(". cast as xs:token", item)}|");
}
