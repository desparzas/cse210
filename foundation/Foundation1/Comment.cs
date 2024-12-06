using System;

class Comment {
    public string commenterName { get; set; }
    public string text { get; set; }

    public Comment(string commenterName, string text) {
        this.commenterName = commenterName;
        this.text = text;
    }

    public override string ToString() {
        return $"{commenterName}: {text}";
    }
}