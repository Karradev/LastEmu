using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeMultiCraftCrafterCanUseHisRessourcesMessage : NetworkMessage
	{
		public const uint Id = 6020;

		public bool allowed;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6020;
			}
		}

		public ExchangeMultiCraftCrafterCanUseHisRessourcesMessage()
		{
		}

		public ExchangeMultiCraftCrafterCanUseHisRessourcesMessage(bool allowed)
		{
			this.allowed = allowed;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.allowed = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.allowed);
		}
	}
}