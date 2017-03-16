using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class AccountHouseMessage : NetworkMessage
	{
		public const uint Id = 6315;

		public AccountHouseInformations[] houses;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6315;
			}
		}

		public AccountHouseMessage()
		{
		}

		public AccountHouseMessage(AccountHouseInformations[] houses)
		{
			this.houses = houses;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.houses = new AccountHouseInformations[num];
			for (int i = 0; i < num; i++)
			{
				this.houses[i] = new AccountHouseInformations();
				this.houses[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.houses.Length));
			AccountHouseInformations[] accountHouseInformationsArray = this.houses;
			for (int i = 0; i < (int)accountHouseInformationsArray.Length; i++)
			{
				accountHouseInformationsArray[i].Serialize(writer);
			}
		}
	}
}