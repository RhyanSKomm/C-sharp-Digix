// namespace Name
// {
//     class ListaEncadeadaDelegate
//     {
//         static delegate void FuncaoDelegate(int valor);

//         string x = null;

//         static delegate void Motoro();

//         static FuncaoDelegate? inicio = null;

//         static FuncaoDelegate CriarNo(int valor, FuncaoDelegate? proximo)
//         {
//             return v =>
//             {
//                 System.Console.WriteLine(valor);
//                 proximo?.Invoke(v);
//             }
//         }
//     }
// }