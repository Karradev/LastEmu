using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GuildPaddockBoughtMessage : NetworkMessage
	{
		public const uint Id = 5952;

		public PaddockContentInformations paddockInfo;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5952;
			}
		}

		public GuildPaddockBoughtMessage()
		{
		}

		public GuildPaddockBoughtMessage(PaddockContentInformations paddockInfo)
		{
			this.paddockInfo = paddockInfo;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.paddockInfo = new PaddockContentInformations();
			this.paddockInfo.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.paddockInfo.Serialize(writer);
		}
	}
}