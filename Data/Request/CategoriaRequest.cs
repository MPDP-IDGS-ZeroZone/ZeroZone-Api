﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ApiTienda.Data.Request;

public partial class CategoriaRequest
{
    public string Nombre { get; set; } = null!;

    public string Foto { get; set; } = null!;
}
