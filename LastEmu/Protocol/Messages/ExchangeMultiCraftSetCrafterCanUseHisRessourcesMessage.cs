using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage : NetworkMessage
	{
		public const uint Id = 6021;

		public bool allow;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6021;
			}
		}

		public ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage()
		{
		}

		public ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage(bool allow)
		{
			this.allow = allow;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.allow = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.allow);
		}
	}
}