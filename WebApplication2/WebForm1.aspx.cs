using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.XPath;

namespace wk2InClassAssignment
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnVersion_Click(object sender, EventArgs e)
		{
			XPathNavigator nav;
			XPathDocument docNav;
			XPathNodeIterator NodeIter;

			String rootPath = Server.MapPath("~");
			string strFilename = rootPath + "\\ContactManager.xml";
			docNav = new XPathDocument(strFilename);

			// Create a navigator to query with XPath.
			nav = docNav.CreateNavigator();
			String searchString = "//VersionDate | //VersionNumber";

			//Select the node and place the results in an iterator.
			NodeIter = nav.Select(searchString);
			nav = NodeIter.Current;
			while (NodeIter.MoveNext())
			{
				txtResult.Text += "\n\nVersion Date = " + nav.Value;
				NodeIter.MoveNext();
				txtResult.Text += "\nVersion Number = " + nav.Value;

			}



		}

		protected void btnContact_Click(object sender, EventArgs e)
		{
			
			XPathNavigator nav;
			XPathDocument docNav;
			XPathNodeIterator NodeIter;

			String rootPath = Server.MapPath("~");
			string strFilename = rootPath + "\\ContactManager.xml";
			docNav = new XPathDocument(strFilename);

			// Create a navigator to query with XPath.
			nav = docNav.CreateNavigator();
			String searchString = "//@Sex | //FirstName | //LastName | //PhoneNumber | //FaxNumber | //EmailAddress";

			//Select the node and place the results in an iterator.
			NodeIter = nav.Select(searchString);
			nav = NodeIter.Current;
			while (NodeIter.MoveNext())
			{
				txtResult.Text += "\n\nGender = " + nav.Value;
				NodeIter.MoveNext();
				txtResult.Text += "\nFirst Name = " + nav.Value;
				NodeIter.MoveNext();
				txtResult.Text += "\nLast Name = " + nav.Value;
				NodeIter.MoveNext();
				txtResult.Text += "\nPhone Number = " + nav.Value;
				NodeIter.MoveNext();
				txtResult.Text += "\nFax Number = " + nav.Value;
				NodeIter.MoveNext();
				txtResult.Text += "\nEmail = " + nav.Value;

			}

			


		}

		protected void btnMen_Click(object sender, EventArgs e)
		{
			XPathNavigator nav;
			XPathDocument docNav;
			XPathNodeIterator NodeIter;

			String rootPath = Server.MapPath("~");
			string strFilename = rootPath + "\\ContactManager.xml";
			docNav = new XPathDocument(strFilename);

			// Create a navigator to query with XPath.
			nav = docNav.CreateNavigator();
			String searchString = "//Contact[@Sex = 'M']/FirstName | //Contact[@Sex = 'M']/LastName | //Contact[@Sex = 'M']/PhoneNumber | //Contact[@Sex = 'M']/FaxNumber | //Contact[@Sex = 'M']/EmailAddress";

			//Select the node and place the results in an iterator.
			NodeIter = nav.Select(searchString);
			nav = NodeIter.Current;
			txtResult.Text += "\n\nMen's Contact Info:";
			while (NodeIter.MoveNext())
			{
				txtResult.Text += "\nFirst Name = " + nav.Value;
				NodeIter.MoveNext();
				txtResult.Text += "\nLast Name = " + nav.Value;
				NodeIter.MoveNext();
				txtResult.Text += "\nPhone Number = " + nav.Value;
				NodeIter.MoveNext();
				txtResult.Text += "\nFax Number = " + nav.Value;
				NodeIter.MoveNext();
				txtResult.Text += "\nEmail = " + nav.Value;

			}
		}

		protected void btnLast_Click(object sender, EventArgs e)
		{
			XPathNavigator nav;
			XPathDocument docNav;
			XPathNodeIterator NodeIter;

			String rootPath = Server.MapPath("~");
			string strFilename = rootPath + "\\ContactManager.xml";
			docNav = new XPathDocument(strFilename);

			// Create a navigator to query with XPath.
			nav = docNav.CreateNavigator();
			String search = txtSearch.Text;
			String searchString = "//Contact[LastName = '"+ search +"']/./@Sex | //Contact[LastName = '" + search + "']/FirstName | //Contact[LastName = '" + search + "']/LastName | //Contact[LastName = '" + search + "']/PhoneNumber |//Contact[LastName = '" + search + "']/FaxNumber | //Contact[LastName = '" + search + "']/EmailAddress";

			//Select the node and place the results in an iterator.
			NodeIter = nav.Select(searchString);
			nav = NodeIter.Current;
			txtResult.Text += "\n\n"+ search +" Contact Info:";
			while (NodeIter.MoveNext())
			{
				txtResult.Text += "\nGender = " + nav.Value;
				NodeIter.MoveNext();
				txtResult.Text += "\nFirst Name = " + nav.Value;
				NodeIter.MoveNext();
				txtResult.Text += "\nLast Name = " + nav.Value;
				NodeIter.MoveNext();
				txtResult.Text += "\nPhone Number = " + nav.Value;
				NodeIter.MoveNext();
				txtResult.Text += "\nFax Number = " + nav.Value;
				NodeIter.MoveNext();
				txtResult.Text += "\nEmail = " + nav.Value;

			}
		}
	}
}
