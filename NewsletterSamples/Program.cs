using NewsletterSamples;

Newspublisher publisher = new Newspublisher();

var user1 = new SUbscriber("Majid");
var user2 = new SUbscriber("Ali");

publisher.Attach(user1);
publisher.Attach(user2);

publisher.Notify($"the C# new update released {DateTime.Now}");

publisher.Detach(user2 );

publisher.Notify($"The .Net new version released {DateTime.Now}");



