﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValoresGlobales : MonoBehaviour
{
	public static Modelos modelo_seleccionado;
}

public enum Modelos
{
		centro_leon,
		estadio_cibao,
		monumento,
		aurora,
		teatro,
		catedral,
		fortaleza,
		matum,
		camp_david,
		parque_central,
		centro_de_la_cultura
}