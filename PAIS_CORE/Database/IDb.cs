namespace PAIS_CORE.Database
{
    internal interface IDb<T>
    {
        void Vloz(T zaznam);
        void Smaz(T zaznam);
        void Smaz(int id);
        void Aktualizuj(T zaznam);
        T Ziskej(int id);
        List<T> ZiskejVsechny();
        int PocetZaznamu();
    }
}
