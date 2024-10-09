namespace DesignPatterns.Abstraction;

public class Example001 {
    // Abstraction reduce complexity by hiding unnecessary details.
    public static void UserMain() {
        EmailService emailService = new EmailService();

        emailService.SendEmail();
    }
}