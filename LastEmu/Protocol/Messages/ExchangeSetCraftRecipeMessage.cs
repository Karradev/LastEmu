using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeSetCraftRecipeMessage : NetworkMessage
	{
		public const uint Id = 6389;

		public uint objectGID;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6389;
			}
		}

		public ExchangeSetCraftRecipeMessage()
		{
		}

		public ExchangeSetCraftRecipeMessage(uint objectGID)
		{
			this.objectGID = objectGID;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.objectGID = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.objectGID);
		}
	}
}