namespace Bank.Controller
{
    public class Account // Luokassa pankkitilin perusominaisuudet
    {
        // viestit poikkeuksille
        public const string DebitAmountExceedsBalanceMessage = "Debit amount exceeds balance";
        public const string DebitAmountLessThanZeroMessage = "Debit amount is less than zero";
        public const string InitialBalanceLessThanZeroMessage = "Initial balance must be non-negative";

        private readonly string? m_customerName;
        private double m_balance;
        private static int s_nextAccountId = 1; // uniikeille account ID:lle (yhdellä asiakkaalla useampi tili)
        public int AccountId { get; private set; } // määrittelee AccountId-ominaisuuden
        public Account(string customerName, double balance) // tilin avauksen käsittely
        {
            if (balance < 0) // avaus-summan tarkistus
            {
                throw new ArgumentOutOfRangeException(nameof(balance), InitialBalanceLessThanZeroMessage);
            }
            m_customerName = customerName;
            m_balance = balance;
            AccountId = s_nextAccountId++; // luo tilille ID:n
        }

        // (expression => member): lyhyempi syntaksi vs. 'get { return }' mutta sama toiminta
        public string? CustomerName => m_customerName;
        public double Balance => m_balance;

        public void Debit(double amount) // metodi tilin debitin käsittelyyn
        {
            if (amount > m_balance) // jos, niin poikkeusviesti parametrin nimellä, arvolla ja viestillä
            {
                throw new System.ArgumentOutOfRangeException(nameof(amount), amount, DebitAmountExceedsBalanceMessage);
            }

            if (amount < 0)
            {
                throw new System.ArgumentOutOfRangeException(nameof(amount), amount, DebitAmountLessThanZeroMessage);
            }

            m_balance -= amount;
        }

        public void Credit(double amount) // credit-käsittelyt
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), amount, "Credit amount is less than zero");
            }

            m_balance += amount;
        }
    }
}
