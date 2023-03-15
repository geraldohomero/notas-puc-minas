int CalcSubsidio() 
{
  int subsidio;
  if (eMaior) 
  {
    subsidio = REJEITA_MAIOR;
  } 
  else if (jaSubsidiado) 
  {
    subsidio = JA_SUBSIDIADO;
  } 
  else if (eTempoParcial) 
  {
    subsidio = TEMPO_INTEGRAL*FATOR;
  } 
  else 
  {
    subsidio = TEMPO_INTEGRAL;
  }
  return subsidio;
}