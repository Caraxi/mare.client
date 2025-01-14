﻿using MareSynchronos.MareConfiguration.Configurations;

namespace MareSynchronos.MareConfiguration;

public class TransientConfigService : ConfigurationServiceBase<TransientConfig>
{
    public const string ConfigName = "transient.json";

    public TransientConfigService(string configDir) : base(configDir)
    {
    }

    protected override string ConfigurationName => ConfigName;
}