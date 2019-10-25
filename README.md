# Framework.CDQXIN.Redis
Redis工具类
Framework.CDQXIN.RedisHelperExt
该支持读写分离的工具类的webconfig配置方式：


<configuration>
    <!--<startup> 
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.7.2" />
    </startup>-->
  <configSections>
    <section name="entityFramework" type="System.Data.Entity.Internal.ConfigFile.EntityFrameworkSection, EntityFramework, Version=v4.7.2, Culture=neutral, PublicKeyToken=b77a5c561934e089" requirePermission="false" />
    <section name="RedisConfig" type="Framework.CDQXIN.RedisHelperExt.RedisConfigInfo, Framework.CDQXIN.RedisHelperExt"/>
  </configSections>
  <RedisConfig WriteServerList="cxd2019@127.0.0.1:6379" ReadServerList="cxd2019@127.0.0.1:6379" MaxWritePoolSize="60" MaxReadPoolSize="60"
               AutoStart="true" LocalCacheTime="180" RecordeLog="false">
  </RedisConfig>
  <connectionStrings>
    <!--正式-->
    <add name="LianXueConnString" connectionString="server=*;database=*;user id=*;password=*;min pool size=4;max pool size=1024;" providerName="System.Data.SqlClient" />
  </connectionStrings>
  <appSettings>
    <!-- Redis测试配置-->
    <add key="RedisConnectionHost" value="127.0.0.1" />
    <add key="RedisConnectionPort" value="6379" />
    <add key="RedisConnectionPassWord" value="cxd2019" />

    <add key="RedisPrev" value="title"/>
  </appSettings>

</configuration>
