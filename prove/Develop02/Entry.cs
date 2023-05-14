namespace Develop02
{
    ///<summary> 
    // The responibility of am entry is to record (or store) a prompt.
    // response, and date.
    ///</summary> 
    class Entry
    {

        public string prompt;
        public string response;
        public string date;

        public string GetAsString()
        {
            return $"Date: {date} - Prompt: {prompt}\n{response}";
        }

        public string GetAsStringForSave()
        {
            return $":{date}:{prompt}:{response}:/n";
        }

        public void Store(string prompt, string response, string date)
        {
            this.prompt = prompt;
            this.response = response;
            this.date = date;
        }
    }
}