using System;
using System.Linq;

namespace CodingChallenge.FamilyTree
{
    public class Solution
    {
        public string GetBirthMonth(Person person, string descendantName)
        {
			var foundPerson = FindPersonByName(person, descendantName);

			if(foundPerson == null)
				return string.Empty;

	        return foundPerson.Birthday.ToString("MMMMMMMMM");
        }

		/// <summary>
		/// Finds a person by name by searching through the given
		/// person and their descendants
		/// </summary>
		/// <returns>
		/// Root person or descendant with the specified name or null if
		/// the person doesn not exist
		/// </returns>
	    private Person FindPersonByName(Person person, string name)
	    {
			if (person.Name == name)
				return person;

			if (person.Descendants == null || !person.Descendants.Any())
				return null;

		    foreach (var child in person.Descendants)
		    {
			    var foundPerson = FindPersonByName(child, name);

				if (foundPerson != null)
					return foundPerson;
		    }

		    return null;
	    }
    }
}